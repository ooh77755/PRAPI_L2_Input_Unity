using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    Vector2 moveInput;

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        print("moveInput:" + moveInput);
    }
}
