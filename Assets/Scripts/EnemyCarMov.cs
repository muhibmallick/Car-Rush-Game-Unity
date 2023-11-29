using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCarMov : MonoBehaviour
{
    public float EnemyCarSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // enemy car will move in y directional only.
        transform.Translate(new Vector3 (0,1,0) * EnemyCarSpeed * Time.deltaTime); 
    }
}
