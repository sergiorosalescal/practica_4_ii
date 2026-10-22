using UnityEngine;

public class humanoid_contact_notifier : MonoBehaviour
{
    public int tipo_humanoide = 1;

    public delegate void mensaje_contacto();
    public static event mensaje_contacto on_cubo_toca_tipo_1;
    public static event mensaje_contacto on_cubo_toca_tipo_2;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Cubo")) {
            notificar_contacto();
        }
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Cubo")) {
            notificar_contacto();
        }
    }

    private void notificar_contacto() {
        Debug.Log("El cubo ha tocado a " + gameObject.name + " (tipo " + tipo_humanoide + ")");

        if (tipo_humanoide == 1 && on_cubo_toca_tipo_1 != null) {
            on_cubo_toca_tipo_1();
        }
        else if (tipo_humanoide == 2 && on_cubo_toca_tipo_2 != null) {
            on_cubo_toca_tipo_2();
        }
    }
}
