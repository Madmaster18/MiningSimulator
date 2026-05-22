using UnityEngine;

public class Ladder : MonoBehaviour
{
    public GameObject ladderObject;
    public float climbForce = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canClimb == false;
    }

    // Update is called once per frame
    void Update()
    {
        if (canClimb = true)
        {
             rb.linearVelocity = new Vector2(rb.linearVelocity.x, climbForce);
        }
    }
    
    public void onCollisionEnter2D (Collider2D other)
    {
        if (other.CompareTag("Ladder"))
        {
            canClimb == true;
        }
    }
}
