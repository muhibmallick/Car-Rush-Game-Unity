using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    // we make carpeed variable to move in x axis , with variable we can decide how quickly car moves from left to right or vice versa.
    public float carspeed;
    public float mmaxpos = 2.2f;
    Vector3 position;

    // making instance
    public UIManager  UI;
    public AudioManager AM;

    private void Awake()
    {
        //acceleration sound will play
        AM.carSound.Play();

    }
    void Start()
    {
        // Gives access to UIManager Script
        //UI = GetComponent<UIManager>();
        // Its is the current position of car at start and which is also temporary.storing in vector3 variable.
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // We are moving car in x direction, below line is the way to get input from keyboard arrowkeys and move left and right.
        // we use Time.deltaTime for frames. and "+" means we are inrementing in x direction. wen clicked.
       position.x += Input.GetAxis("Horizontal") * carspeed * Time.deltaTime;

        // we use built in funtion to stop the car if the vlalue of x reaches certain point. if that the case the car will stop moving in x direction.
        // in short it limits the value.
       position.x = Mathf.Clamp(position.x, -2.2f, 2.2f);

        // Updating the value or posion of the car, so it may seen move on screen.
        transform.position = position;
        
    }

    // Built in funtion tell if anycollision happen with enemy car then destroy our gameobject [script on which gameobject is attach] (Driving car(red car)).
     void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy Car")
        {
            Destroy(gameObject);
            UI.GameOverActivated();
            AM.carSound.Stop();
        }
    }
}
