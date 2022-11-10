using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed = 20;
    [SerializeField]
    private float jumpForce = 400;
    [SerializeField]
    private Vector2 movementInput = Vector2.zero;
    [SerializeField]
    private bool jumped = false;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        jumped = context.action.triggered;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if(movementInput != Vector2.zero){
            
        }
    }
}
