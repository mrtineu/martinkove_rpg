using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D rb;
    public float speed = 200f;
    Vector2 movement = new Vector2(0, 0);
    void Awake()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Vector2.zero;
        
        if (Input.GetKey(KeyCode.W))
        {
            movement.y = 1;
        } else if (Input.GetKey(KeyCode.S))
        {
            movement.y = -1;
        }

        if (Input.GetKey(KeyCode.A))
        {
            movement.x = -1;
        } else if (Input.GetKey(KeyCode.D))
        {
            movement.x = 1;
        }
        
        Debug.Log(movement);
    }
    

    void FixedUpdate()
    {
        rb.AddForce(movement.normalized * (speed * Time.fixedDeltaTime));

    }
}
