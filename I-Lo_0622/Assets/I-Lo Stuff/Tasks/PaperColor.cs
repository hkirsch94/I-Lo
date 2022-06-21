using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperColor : MonoBehaviour
{

    //Gameobject and Texture
    public Texture green;
    public List<Renderer> rend;


    // Use this for initialization
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    { 

        if (Input.GetKey("1")) 
        {
            rend[0].material.mainTexture = green;
        }
        else if (Input.GetKey("2"))
        {
            rend[1].material.mainTexture = green;
        }
        else if (Input.GetKey("3"))
        {
            rend[2].material.mainTexture = green;
        }
        else if (Input.GetKey("4"))
        {
            rend[3].material.mainTexture = green;
        }
        else if (Input.GetKey("5"))
        {
            rend[4].material.mainTexture = green;
        }
    }
}
