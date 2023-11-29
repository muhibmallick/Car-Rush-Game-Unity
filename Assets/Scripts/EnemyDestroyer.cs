using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // destroy collided object not the object itself.
        if (collision.gameObject.tag == "Enemy Car")
        {
            Destroy(collision.gameObject);
        }
    }
}
