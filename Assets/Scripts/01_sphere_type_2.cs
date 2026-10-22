using UnityEngine;

public class sphere_type_2 : MonoBehaviour
{
    public cylinder_notifier notificador_cilindro;

    public float velocidad = 3f;

    private bool debe_moverse = false;

    void OnEnable() {
        if (notificador_cilindro != null) {
            notificador_cilindro.on_cubo_colisiona += ir_hacia_cilindro;
        }
    }

    void OnDisable() {
        if (notificador_cilindro != null) {
            notificador_cilindro.on_cubo_colisiona -= ir_hacia_cilindro;
        }
    }

    private void ir_hacia_cilindro() {
        Debug.Log(gameObject.name + " (tipo 2) recibe el mensaje y se dirige hacia el cilindro");
        debe_moverse = true;
    }

    void Update() {
        if (debe_moverse) {
            Vector3 posicion_cilindro = notificador_cilindro.transform.position;
            Vector3 destino = new Vector3(posicion_cilindro.x, transform.position.y, posicion_cilindro.z);
            transform.position = Vector3.MoveTowards(transform.position, destino, velocidad * Time.deltaTime);
        }
    }
}
