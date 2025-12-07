using UnityEngine;

public class KeyboardMovement : IMovementStrategy
{
    public Vector2 GetMovementInput()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        return new Vector2(x, y).normalized;
    }
}
