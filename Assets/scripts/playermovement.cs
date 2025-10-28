using UnityEngine;

public class playermovement : MonoBehaviour
{
  public Rigidbody rb;
    public float forwardforde = 2000f;
    public float rightforce = 500f;
   
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardforde * Time .deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(rightforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce( -rightforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f)
        {
          FindObjectOfType<gamemanagaer>().EndGame();   
        }

    }
    
}
