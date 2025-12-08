using UnityEngine;

public class PlayerView : MonoBehaviour
{
    public Rigidbody2D rb;

    public void Move(Vector2 movement, float speed)
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
