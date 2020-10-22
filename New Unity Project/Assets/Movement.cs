using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody rb;
    public float force = 200f;
    public float jumpforce = 10f;
    public bool grounded = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Ground")
        {
            grounded = true;
        }
    }


    // Update is called once per frame
    void  FixedUpdate()
    {
        //check if on ground


        if (Input.GetKey("d"))
        {
            rb.AddForce(force,0,0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-force, 0, 0);
        }

        if (Input.GetKey("space") && grounded == true)
        {
                rb.AddForce(0, jumpforce, 0);
                grounded = false;
            
        }

        if (rb.position.y < -5f)
        {
            FindObjectOfType<GameManager>().endgame();
        }
    }
}
