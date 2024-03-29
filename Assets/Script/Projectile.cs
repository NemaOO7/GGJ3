using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Vector3 targetPostion;
    public float speed;
    
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
