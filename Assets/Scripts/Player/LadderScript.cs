using UnityEngine;

public class LadderScript : MonoBehaviour

{
    public float climbForce = 2.0f;
    private Rigidbody2D rb;
    public bool canClimb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && canClimb)
        {
            // Apply upward force instantly
            rb.AddForce(Vector3.up * climbForce * Time.deltaTime);
            canClimb = false;
        }
    }
     private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ladder"))
        {
           canClimb = true;
           Debug.Log("COLLIDE");
           {
                
           }
        }
    }
}
