using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using WebSocketSharp;

public class LocationUpdate : MonoBehaviour
{
    WebSocket ws;
    string intent;
    private void Start()
    {
        ws = new WebSocket("ws://localhost:12101/api/events/intent");

        ws.OnMessage += GetIntend;
        ws.Connect();
        


    }

    private void Update()
    {
        if (ws == null)
        {
            return;
        }
        else if (intent == "GoCharge")
        {
            transform.position = new Vector3(4, 0, -5);
            intent = "";
        }
        else if (intent == "GoBathroom")
        {
            transform.position = new Vector3(-1, 0, -9);
            intent = "";
        }
        else if (intent == "GoKitchen")
        {
            transform.position = new Vector3(-3, 0, 4);
            intent = "";
        }
        else if (intent == "GoLivingRoom")
        {
            transform.position = new Vector3(3, 0, -1);
            intent = "";
        }
    }

    public void GetIntend(object sender, MessageEventArgs e) 
    {

        char[] delimiterChars = { ' ', ',', '.', ':', '"', '{', '}' };
        string[] words = e.Data.Split(delimiterChars);
        string word = words[11];
        Debug.Log("Data: " + word);
        intent = word;

    }
    
        
        

}
