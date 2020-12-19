using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private Transform UFO;
    Rigidbody2D rb;
    SpriteRenderer sr;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

        

    }

    // Update is called once per frame
    void Update()
    {
      float adjustedSpeed = enemyspeed + speedModifier;

        transform.position += (Vector3.right * adjustedSpeed * Time.deltaTime);


    }



}
