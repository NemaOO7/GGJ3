using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRun : MonoBehaviour
{
   
    Vector3 targetPostion;
    public float speed;
    // Update is called once per frame
    void start()
    {
        targetPostion = FindObjectOfType<PlayerMovement>().transform.position;
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPostion, speed * Time.deltaTime);
        if (transform.position == targetPostion)
        {
            Destroy(gameObject);
        }
        
    }
}
