using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    float xMove;
    public float moveSpeed = 6;
    public float bulletSpeed = 200;
    public float autofireDelay = 0.001f;
    bool autofire = true;
    private Transform UFO;
    public GameObject PlayerCannon;

    float t;
    private Vector2 movement;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    void Update()
    {

        xMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
           if (autofire)
            {
                if (t > 0)
                {
                    t -= Time.deltaTime;
                } else
                {
                    //Fire();
                    t = autofireDelay;
                }
            }
        }
    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(xMove, 0);
        rb.velocity = movement;
    }

  /*  void MovePlayer()
    {
        velocity.x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        rb.AddForce(moveDirection, ForceMode2D.Force);
    }

        float xValue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        Vector3 moveDirection = new Vector3(xValue, 0.0f, 0.0f);

       */
}
