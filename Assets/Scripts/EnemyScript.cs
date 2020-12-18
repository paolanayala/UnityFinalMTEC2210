using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float enemyspeed;
    private float speedModifier = 0;
    // Start is called before the first frame update
    void Start()
    {
        speedModifier = Random.value * 4;

        Debug.Log("Speed Modifier: " + speedModifier);

    }

    // Update is called once per frame
    void Update()
    {
        float adjustedSpeed = enemyspeed + speedModifier;
        transform.position += (Vector3.right * adjustedSpeed * Time.deltaTime);


    }



}
