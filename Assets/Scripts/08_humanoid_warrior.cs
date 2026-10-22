using UnityEngine;

public class humanoid_warrior : MonoBehaviour
{
    public Transform enemigo;
    public float velocidad = 2f;
    public Color color_al_combatir = Color.red;

    private bool en_guerra = false;
    private Renderer[] renderers_humanoide;

    void Start() {
        renderers_humanoide = GetComponentsInChildren<Renderer>();
    }

    void OnEnable() {
        war_notifier.on_empieza_guerra += empezar_guerra;
    }

    void OnDisable() {
        war_notifier.on_empieza_guerra -= empezar_guerra;
    }

    private void empezar_guerra() {
        Vector3 punto_mirada = new Vector3(enemigo.position.x, transform.position.y, enemigo.position.z);
        transform.LookAt(punto_mirada);
        en_guerra = true;
        Debug.Log(gameObject.name + " se lanza a por " + enemigo.name);
    }

    void Update() {
        if (en_guerra) {
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (en_guerra && other.CompareTag("Humanoide")) {
            en_guerra = false;
            Debug.Log("¡" + gameObject.name + " combate contra " + other.gameObject.name + "!");

            foreach (Renderer renderer_humanoide in renderers_humanoide) {
                renderer_humanoide.material.color = color_al_combatir;
            }
        }
    }
}
