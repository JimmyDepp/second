using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forward_force = 2000f;
    public float sideways_force = 1000f;
    
    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, forward_force * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideways_force* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideways_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (rb.position.y<-1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
