using UnityEngine;

public class cylinder_notifier : MonoBehaviour
{
    public delegate void mensaje_colision();
    public event mensaje_colision on_cubo_colisiona;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Cubo")) {
            Debug.Log("El cubo ha colisionado con el cilindro. Enviando mensaje a las esferas...");

            if (on_cubo_colisiona != null) {
                on_cubo_colisiona();
            }
        }
    }
}
