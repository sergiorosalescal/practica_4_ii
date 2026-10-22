using UnityEngine;

public class war_notifier : MonoBehaviour
{
    public delegate void mensaje_guerra();
    public static event mensaje_guerra on_empieza_guerra;

    private bool guerra_iniciada = false;

    private void OnTriggerEnter(Collider other) {
        if (!guerra_iniciada && (other.CompareTag("EscudoTipo1") || other.CompareTag("EscudoTipo2"))) {
            guerra_iniciada = true;
            Debug.Log("El cubo ha recogido el escudo " + other.gameObject.name + ". ¡Empieza la guerra!");

            if (on_empieza_guerra != null) {
                on_empieza_guerra();
            }
        }
    }
}
