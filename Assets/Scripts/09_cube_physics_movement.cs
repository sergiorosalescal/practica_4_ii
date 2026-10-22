using UnityEngine;

public class cube_physics_movement : MonoBehaviour
{
    public float fuerza_movimiento = 20f;

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
            rb.AddForce(direccion_movimiento.normalized * fuerza_movimiento);
        }
    }
}
