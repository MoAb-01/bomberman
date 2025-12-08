using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerView view;

    private PlayerModel model;
    private IMovementStrategy movement;

    void Start()
    {
        model = new PlayerModel();
        movement = new KeyboardMovement();  // Strategy DP
    }

    void FixedUpdate()
    {
        Vector2 input = movement.GetMovementInput();
        view.Move(input, model.Speed);
    }
}
