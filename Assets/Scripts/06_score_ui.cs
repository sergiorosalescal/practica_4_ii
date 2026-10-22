using UnityEngine;
using TMPro;

public class score_ui : MonoBehaviour
{
    public score_manager gestor_puntuacion;
    public TMP_Text texto_puntuacion;

    void OnEnable() {
        if (gestor_puntuacion != null) {
            gestor_puntuacion.on_puntuacion_cambiada += actualizar_texto;
        }
    }

    void OnDisable() {
        if (gestor_puntuacion != null) {
            gestor_puntuacion.on_puntuacion_cambiada -= actualizar_texto;
        }
    }

    void Start() {
        actualizar_texto(0);
    }

    private void actualizar_texto(int puntuacion_actual) {
        texto_puntuacion.text = "Puntuación: " + puntuacion_actual;
    }
}
