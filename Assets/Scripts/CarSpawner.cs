using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject[] cars;
    int CarNo;
    public float mmaxpos = 2.2f;
    public float delayTimer = 1f;
    float timer;
    void Start()
    {
        timer = delayTimer;

         // creating temporary position of car also being random in between values 2.2 to -2.2.Random position only happening in x direction.
         // Vector3 carPos = new Vector3(Random.Range(-2.2f, 2.2f), transform.position.y, transform.position.z);
         // Now we have passed car pos in Y directonal
         // Instantiate(car, carPos, transform.rotation);
         // we are giving the car object position and rotation to it. in the start.
         // Instantiate(car, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        // timer value will be decremented with the help of Time.deltaTime(frames).(Each time frame is called value will be decremented)
        timer -= Time.deltaTime;
        // if the condition becomes true then it will perfom the action.or spawmn the car.
        if (timer<=0)
        {
            //Inorder to spawn car again and again we need to do below line of code in Update funtion.
            Vector3 carPos = new Vector3(Random.Range(-2.2f, 2.2f), transform.position.y, transform.position.z);
            CarNo = Random.Range(0,5);
            Instantiate(cars[CarNo], carPos, transform.rotation);

            // resetting timer value to 1
            timer = delayTimer;

        }
        
    }
}
