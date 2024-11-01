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
    [SerializeField] float xMin, xMax, yMin, yMax;
    [SerializeField] float currentX, currentY;
   


    private void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
    }

    

    private void Update()
    {
        currentX = Mathf.Clamp(transform.position.x, xMin, xMax);
        currentY = Mathf.Clamp(transform.position.y, yMin, yMax);
        transform.position = new Vector2(currentX, currentY);
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
