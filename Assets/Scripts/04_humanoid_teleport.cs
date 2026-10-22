using UnityEngine;

public class humanoid_teleport : MonoBehaviour
{
    public proximity_notifier objeto_referencia;
    public Transform escudo_objetivo;

    void OnEnable() {
        if (objeto_referencia != null) {
            objeto_referencia.on_cubo_cerca += teletransportar;
        }
    }

    void OnDisable() {
        if (objeto_referencia != null) {
            objeto_referencia.on_cubo_cerca -= teletransportar;
        }
    }

    private void teletransportar() {
        transform.position = new Vector3(escudo_objetivo.position.x, transform.position.y, escudo_objetivo.position.z);
        Debug.Log(gameObject.name + " (grupo 1) se ha teletransportado al escudo " + escudo_objetivo.name);
    }
}
