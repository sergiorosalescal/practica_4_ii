using UnityEngine;

public class proximity_notifier : MonoBehaviour
{
    public Transform cubo;
    public float distancia_activacion = 3f;

    public delegate void mensaje_proximidad();
    public event mensaje_proximidad on_cubo_cerca;

    private bool cubo_dentro = false;

    void Update() {
        float distancia = Vector3.Distance(transform.position, cubo.position);

        if (distancia <= distancia_activacion && !cubo_dentro) {
            cubo_dentro = true;
            Debug.Log("El cubo se ha aproximado al objeto de referencia");

            if (on_cubo_cerca != null) {
                on_cubo_cerca();
            }
        }
        else if (distancia > distancia_activacion) {
            cubo_dentro = false;
        }
    }
}
