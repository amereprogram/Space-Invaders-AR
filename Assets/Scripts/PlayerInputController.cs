using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
    private bool moveLeft, moveRight, fire;

    void FixedUpdate()
    {
        if (fire)
            //BaseController.Instance.Fire();
            Debug.Log("Player Fired");
        if (moveLeft)
            //BaseController.Instance.MoveLeft();
            Debug.Log("Player Moved Left");
        if (moveRight)
            //BaseController.Instance.MoveRight();
            Debug.Log("Player Moved Right");
    }

    public void OnFire(InputValue inputValue)
    {
        fire = inputValue.isPressed;
        print("player fired");
    }

    public void OnMoveLeft(InputValue inputValue)
    {
        moveLeft = inputValue.isPressed;
        print("player moved left");
    }

    public void OnMoveRight(InputValue inputValue)
    {
        moveRight = inputValue.isPressed;
        print("player moved right");
    }
}
