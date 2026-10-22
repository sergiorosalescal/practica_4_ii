using UnityEngine;

public class humanoid_look_at : MonoBehaviour
{
    public proximity_notifier objeto_referencia;
    public Transform objeto_orientacion;

    void OnEnable() {
        if (objeto_referencia != null) {
            objeto_referencia.on_cubo_cerca += orientarse;
        }
    }

    void OnDisable() {
        if (objeto_referencia != null) {
            objeto_referencia.on_cubo_cerca -= orientarse;
        }
    }

    private void orientarse() {
        Vector3 punto_mirada = new Vector3(objeto_orientacion.position.x, transform.position.y, objeto_orientacion.position.z);
        transform.LookAt(punto_mirada);
        Debug.Log(gameObject.name + " (grupo 2) se orienta hacia " + objeto_orientacion.name);
    }
}
