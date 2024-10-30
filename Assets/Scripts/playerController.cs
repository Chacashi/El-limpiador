using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    Rigidbody2D _compRigidbody2D;
    [SerializeField] float speed;
    float vertical;
    float horizontal;


    private void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void AxisY(InputAction.CallbackContext context)
    {
        vertical = context.ReadValue<float>();
    }

    public void AxisX(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<float>();
    }



    private void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(speed * horizontal, speed * vertical);
    }



}
