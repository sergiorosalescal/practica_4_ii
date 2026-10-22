using UnityEngine;

public class cube_movement : MonoBehaviour
{
    public float velocidad = 5f;

    private Rigidbody rb;
    private Vector3 direccion_movimiento;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
        float movimiento_horizontal = Input.GetAxis("Horizontal");
        float movimiento_vertical = Input.GetAxis("Vertical");

        direccion_movimiento = new Vector3(movimiento_horizontal, 0f, movimiento_vertical);
    }

    void FixedUpdate() {
        if (direccion_movimiento.magnitude > 0.01f) {
            Vector3 nueva_posicion = rb.position + direccion_movimiento.normalized * velocidad * Time.fixedDeltaTime;
            rb.MovePosition(nueva_posicion);
        }
    }
}
