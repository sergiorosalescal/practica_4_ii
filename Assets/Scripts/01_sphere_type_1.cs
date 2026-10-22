using UnityEngine;

public class sphere_type_1 : MonoBehaviour
{
    public cylinder_notifier notificador_cilindro;
    public Transform esfera_objetivo;

    public float velocidad = 3f;

    private bool debe_moverse = false;

    void OnEnable() {
        if (notificador_cilindro != null) {
            notificador_cilindro.on_cubo_colisiona += ir_hacia_esfera_objetivo;
        }
    }

    void OnDisable() {
        if (notificador_cilindro != null) {
            notificador_cilindro.on_cubo_colisiona -= ir_hacia_esfera_objetivo;
        }
    }

    private void ir_hacia_esfera_objetivo() {
        Debug.Log(gameObject.name + " (tipo 1) recibe el mensaje y se dirige hacia " + esfera_objetivo.name);
        debe_moverse = true;
    }

    void Update() {
        if (debe_moverse && esfera_objetivo != null) {
            Vector3 destino = new Vector3(esfera_objetivo.position.x, transform.position.y, esfera_objetivo.position.z);
            transform.position = Vector3.MoveTowards(transform.position, destino, velocidad * Time.deltaTime);
        }
    }
}
