using UnityEngine;

class PlatformerPlayer2D : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody;
    [SerializeField] float jumpVelocity;
    [SerializeField] float horizontalSpeed;
    [SerializeField] int airJump;

    bool isGrounded;
    int currentAirJumpBudget;

    void OnValidate()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Jump
        if ((isGrounded || currentAirJumpBudget >0) && Input.GetKeyDown(KeyCode.Space)) 
        {
            rigidbody.velocity = Vector2.zero;
            rigidbody.AddForce(
                Vector2.up * jumpVelocity * rigidbody.mass, ForceMode2D.Impulse);

            if (!isGrounded) 
            {
                currentAirJumpBudget--;
            }
        }
    }

    void FixedUpdate()
    {
        // Movement
        float inputX = Input.GetAxis("Horizontal");

        Vector2 velocity = new Vector2(inputX * horizontalSpeed, rigidbody.velocity.y);
        rigidbody.velocity = velocity;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        currentAirJumpBudget = airJump;
        // Debug.Log("Collide: " + collision.otherCollider.name);
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
        // Debug.Log("Exit");
    }
}
