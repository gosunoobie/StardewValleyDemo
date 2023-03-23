using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class CharacterController2D : MonoBehaviour
{
    Rigidbody2D rigidbody;
    [SerializeField] float moveSpeed = 2f;
    Vector2 movementVector;
    public Vector2 lastMovementVector;
    Animator animator;
    public bool isMoving;
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

   private void Update() {
    float vertical = Input.GetAxisRaw("Vertical");
    float horizontal = Input.GetAxisRaw("Horizontal");

      movementVector = new Vector2(horizontal,vertical);
      animator.SetFloat("horizontal",horizontal);
      animator.SetFloat("vertical",vertical);
   
   isMoving = vertical != 0 || horizontal !=0;
   animator.SetBool("isMoving",isMoving);
    
   if(vertical !=0 || horizontal != 0){
    lastMovementVector = new Vector2(horizontal,vertical).normalized;
    animator.SetFloat("lastHorizontal",horizontal);
    animator.SetFloat("lastVertical",vertical);
   }

   }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    private void Move(){
   rigidbody.velocity = movementVector * moveSpeed;
    }
}
