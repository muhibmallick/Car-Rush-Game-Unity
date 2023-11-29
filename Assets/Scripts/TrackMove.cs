using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TrackMove : MonoBehaviour
{
    public  float Speed;
    
    Vector2 offset; //texture will move with the help of offset variable.

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Since we need to move only in "y axis" derection so the value of x is zero.
        // Time.time means we will increase the value in according with time.
        offset = new Vector2(0, Time.time * Speed);
        //**Gets renderer first**Acess material within renderer**Gives maintextureoffset** puts offset value inside offset variable**
        // And so texture is keep moving downwards
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
