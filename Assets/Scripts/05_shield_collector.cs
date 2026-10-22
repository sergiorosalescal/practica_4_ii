using UnityEngine;

public class shield_collector : MonoBehaviour
{
    public int puntos_escudo_tipo_1 = 5;
    public int puntos_escudo_tipo_2 = 10;

    private int puntuacion = 0;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("EscudoTipo1")) {
            recoger_escudo(other.gameObject, puntos_escudo_tipo_1);
        }
        else if (other.CompareTag("EscudoTipo2")) {
            recoger_escudo(other.gameObject, puntos_escudo_tipo_2);
        }
    }

    private void recoger_escudo(GameObject escudo, int puntos) {
        puntuacion += puntos;
        Debug.Log("Escudo recogido: " + escudo.name + " (+" + puntos + "). Puntuación: " + puntuacion);
        Destroy(escudo);
    }
}
