using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using WebSocketSharp;

public class RhasspyConnect : MonoBehaviour
{
    WebSocket ws_r;
    WebSocket ws_s;
    string intent;
    private void Start()
    {
        ws_r = new WebSocket("ws://localhost:12101/api/events/intent");
        ws_s = new WebSocket("ws://localhost:12101/api/text-to-speech");

        ws_r.OnMessage += GetIntend;
        ws_r.Connect();
        ws_s.Connect();


    }

    private void Update()
    {
        if (ws_r == null)
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

        if (Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log("Send");
            ws_s.Send("Hello");
            
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
