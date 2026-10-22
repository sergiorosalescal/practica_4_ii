using UnityEngine;

public class humanoid_color_change : MonoBehaviour
{
    public Color color_al_colisionar = Color.red;

    private Renderer[] renderers_humanoide;

    void Start() {
        renderers_humanoide = GetComponentsInChildren<Renderer>();
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("EscudoTipo1") || collision.gameObject.CompareTag("EscudoTipo2")) {
            Debug.Log("El humanoide " + gameObject.name + " ha colisionado con el escudo " + collision.gameObject.name);

            foreach (Renderer renderer_humanoide in renderers_humanoide) {
                renderer_humanoide.material.color = color_al_colisionar;
            }
        }
    }
}
