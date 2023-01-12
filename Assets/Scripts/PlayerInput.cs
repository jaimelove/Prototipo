using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Input inputActions;
    public bool MoveRight;
    public bool MoveLeft;
    public Vector2 Jump;

  

    
    void Update()
    {
        MoveRight = inputActions.move.MoveRight.IsPressed();
        MoveLeft = inputActions.move.MoveLeft.IsPressed();
        Jump = inputActions.move.Jump.ReadValue<Vector2>().normalized;
    }
    private void OnEnable()
    {
        inputActions.Enable();
    }
    private void OnDisable()
    {
        inputActions.Disable();
    }

}
