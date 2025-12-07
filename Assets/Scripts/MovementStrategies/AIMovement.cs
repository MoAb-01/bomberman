using UnityEngine;

public class AIMovement : IMovementStrategy
{
    public Vector2 GetMovementInput()
    {
        // Example: AI stands still
        return Vector2.zero;
    }
}
