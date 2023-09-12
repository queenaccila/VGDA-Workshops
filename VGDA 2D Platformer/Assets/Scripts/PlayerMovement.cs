using UnityEngine;

///-///////////////////////////////////////////////////////////
/// Player movement logic based off of : https://www.youtube.com/watch?v=K1xZ-rycYY8&list=PL23sWYHuItaqqoAjlKUWFKSf1AHN4dwWS
/// 
public class PlayerMovement : MonoBehaviour
{

    private float horizontal;
    [SerializeField]
    [Range(0, 20)]
    private float speed = 8f;
    [SerializeField][Range(0, 50)]
    private float jumpingPower = 16f;
    private bool isFacingRight = true;
    private bool doubleJump;
    [Header("Player Movement Variables")]
    [SerializeField] private  Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Animator animator;

    

    ///-///////////////////////////////////////////////////////////
    /// CPU based update game loop
    void Update()
    {

        ReadMovement();
        CheckJump();
        Flip();
    }
    ///-///////////////////////////////////////////////////////////
    /// Physics update game loop
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    ///-///////////////////////////////////////////////////////////
    ///
    void ReadMovement()
    {
          //Get literal input from keys labelled horizontal in our project game settings
        horizontal = Input.GetAxisRaw("Horizontal");

        animator.SetFloat("Speed", Mathf.Abs(horizontal));
    }
    ///-///////////////////////////////////////////////////////////
    ///
    private void CheckJump()
    {
        //Check for animator
        if (IsGrounded())
        {
            animator.SetBool("Jump", false);
        }

        // Double jump check
        if (IsGrounded() && Input.GetKey(KeyCode.Space) == false)
        {
            doubleJump = false;
        }

        //actual input check
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (IsGrounded() || doubleJump)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
                doubleJump = !doubleJump;
                animator.SetBool("Jump", true);
            }

        }

        // for long press jumps for the super cool bouncy feel B)
        if (Input.GetKeyUp(KeyCode.Space) && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
    }




    ///-///////////////////////////////////////////////////////////
    /// Makes big circle at our ground check position (feet) to see if we're touching the floor
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    ///-///////////////////////////////////////////////////////////
    ///
    private void Flip() { 
      // Flip our GameObject every time we change direction
        if(isFacingRight && horizontal < 0f || isFacingRight == false && horizontal > 0f)
        {
            //Invert Transform of object
            // this could be done a better way. Maybe you can fixt it ;)
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
