using UnityEngine;

public class controlePersonagem : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    private float moveX;

    public Transform groundCheck;
    public LayerMask groundLayer;

    public Transform visual;
    public Animator anim; 

    private bool isGrounded;

    void Start(){
      rb2d = GetComponent<Rigidbody2D>();
      anim = visual.GetComponent<Animator>();
   }

    void Update(){
      moveX = Input.GetAxisRaw("Horizontal");
      isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);

      float moveInput = Input.GetAxisRaw("Horizontal");
      rb2d.linearVelocity = new Vector2(moveInput * moveSpeed, rb2d.linearVelocity.y);

      anim.SetBool("flutuando", !isGrounded);

      if (moveInput > 0.1f){
        visual.localScale = new Vector3(1,1,1);
      }
      else if(moveInput < -0.1f){
        visual.localScale = new Vector3(-1,1,1);
      }

      if(Input.GetButtonDown("Jump")&& isGrounded){
        Jump(); 
      }



    Move();
   }

    void Move(){
      rb2d.linearVelocity = new Vector2(moveX * moveSpeed, rb2d.linearVelocity.y);
    }

    void Jump(){
      rb2d.linearVelocity = new Vector2(rb2d.linearVelocity.x, jumpForce);
    } 
  }

