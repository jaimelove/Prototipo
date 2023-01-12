using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    PlayerInputActions inputActions;
    public bool MoveRight;
    public bool MoveLeft;
    public Vector2 Jump;
    public float LeftRight;

    private void Awake()
    {
        inputActions = new PlayerInputActions();
    }

    void Update()
    {
        Debug.Log(inputActions.move.MoveRight.IsPressed());
        Debug.Log(inputActions.move.MoveLeft.IsPressed());
        //Debug.Log(inputActions.move.Jump.ReadValue<Vector2>());
        //Debug.Log(inputActions.move.MoveRightLeft.ReadValue<float>());


        MoveRight = inputActions.move.MoveRight.IsPressed();
        MoveLeft = inputActions.move.MoveLeft.IsPressed();

        Jump = inputActions.move.Jump.ReadValue<Vector2>().normalized;
        LeftRight = inputActions.move.MoveRightLeft.ReadValue<float>();
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
