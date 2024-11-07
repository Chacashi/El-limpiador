using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;
public class playerController : MonoBehaviour
{
    Rigidbody2D _compRigidbody2D;
    [SerializeField] float speed;
    float vertical;
    float horizontal;
    [SerializeField] float xMin, xMax, yMin, yMax;
    [SerializeField] float currentX, currentY;
   public static event Action OnYellEnemy1;
   public static event Action OnYellEnemy2;

    bool isYell;


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

    public void ButtonZ (InputAction.CallbackContext context) 
    {
       
    }

    public void ButtonX(InputAction.CallbackContext context)
    {

    }

    public void ButtonC(InputAction.CallbackContext context)
    {
        isYell = context.performed;
    }


    private void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(speed * horizontal, speed * vertical);
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision != null && collision.gameObject.tag == "Enemy1" && isYell==true)
        {
            OnYellEnemy1?.Invoke();
            isYell=false;
        }
        if (collision != null && collision.gameObject.tag == "Enemy2" && isYell == true)
        {
            OnYellEnemy2?.Invoke();
            isYell = false;
        }
    }


}
