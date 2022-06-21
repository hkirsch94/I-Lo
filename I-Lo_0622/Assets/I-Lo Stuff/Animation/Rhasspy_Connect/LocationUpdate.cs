using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LocationUpdate : MonoBehaviour
{
    private void Start()
    {

        
    }

    private void Update()
    {
        //Goto ChargingStation
        if (Input.GetKey("p"))
        {
            transform.position = new Vector3(4, 0, -5);
        }
        //Goto Bathroom
        else if (Input.GetKey("g"))
        {
            transform.position = new Vector3(-1, 0, -9);
        }
        //Goto Kitchen
        else if (Input.GetKey("k"))
        {
            transform.position = new Vector3(-3, 0, 4);
        }
        //Goto LivingRoom
        else if (Input.GetKey("v"))
        {
            transform.position = new Vector3(3, 0, -1);
        }
        //Goto Bedroom
        else if (Input.GetKey("r"))
        {
            transform.position = new Vector3(4, 0, -5);
        }
        
    }
     

}
