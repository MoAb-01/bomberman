using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;
    private IMovementStrategy movementStrategy;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movementStrategy = new KeyboardMovement();
    }

    void FixedUpdate()
    {
        Vector2 input = movementStrategy.GetMovementInput();
        rb.MovePosition(rb.position + input * speed * Time.fixedDeltaTime);
    }
}
