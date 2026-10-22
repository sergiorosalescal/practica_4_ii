using UnityEngine;

public class humanoid_group_1 : MonoBehaviour
{
    public Transform escudo_seleccionado;
    public Transform escudo_tipo_2;

    public float velocidad = 3f;

    private Transform destino_actual;

    void OnEnable() {
        humanoid_contact_notifier.on_cubo_toca_tipo_2 += ir_hacia_escudo_seleccionado;
        humanoid_contact_notifier.on_cubo_toca_tipo_1 += ir_hacia_escudo_tipo_2;
    }

    void OnDisable() {
        humanoid_contact_notifier.on_cubo_toca_tipo_2 -= ir_hacia_escudo_seleccionado;
        humanoid_contact_notifier.on_cubo_toca_tipo_1 -= ir_hacia_escudo_tipo_2;
    }

    private void ir_hacia_escudo_seleccionado() {
        Debug.Log(gameObject.name + " (grupo 1) se dirige al escudo seleccionado " + escudo_seleccionado.name);
        destino_actual = escudo_seleccionado;
    }

    private void ir_hacia_escudo_tipo_2() {
        Debug.Log(gameObject.name + " (grupo 1) se dirige al escudo de tipo 2 " + escudo_tipo_2.name);
        destino_actual = escudo_tipo_2;
    }

    void Update() {
        if (destino_actual != null) {
            Vector3 destino = new Vector3(destino_actual.position.x, transform.position.y, destino_actual.position.z);
            transform.position = Vector3.MoveTowards(transform.position, destino, velocidad * Time.deltaTime);
        }
    }
}
