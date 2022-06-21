using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using WebSocketSharp;

public class I_Lo_Script_Body : MonoBehaviour
{
    //Websocket
    WebSocket ws;
    string intent;



    //Gameobject and Texture
    public List<Texture2D> textures = new List<Texture2D>();
    public List<Texture2D> talkFaces = new List<Texture2D>();
    public Renderer rend;

    //For facing player
    int damping = 2;
    public Transform target;
    public Transform target_sleep;


    [SerializeField]

    private Animator animator;
    private string currentAnimaton;


    [SerializeField]


    //Animation States

    const string Idle = "Idle";
    const string Forward = "Forward";



    int timer = 0;










    //=====================================================
    // Start is called before the first frame update
    //=====================================================
    void Start()
    {
        //animator
        animator = GetComponent<Animator>();

        //Websocket
        ws = new WebSocket("ws://localhost:12101/api/events/intent");
        ws.OnMessage += GetIntend;
        ws.Connect();


    }

    //=====================================================
    // Update is called once per frame
    //=====================================================
    void Update()
    {


        //Change Location

        if (!(isLocation()))
        {
            ChangeAnimationState(Forward);
        }
        else
        {
            ChangeAnimationState(Idle);
            if (!(intent == "GoCharge")) 
            { 
            var lookPos = target.position - transform.position;
            lookPos.y = 0;
            var rotation = Quaternion.LookRotation(lookPos);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
            }
            else
            {
                var lookPos = target_sleep.position - transform.position;
                lookPos.y = 0;
                var rotation = Quaternion.LookRotation(lookPos);
                transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
                rend.material.mainTexture = textures[5];
            }
        }

        //Animations

        if (ws == null)
        {
            return;
        }
        else if (intent == "Hello")
        {

            timer += 1;

            if (timer > 6000)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];
            }


        }
        else if (intent == "Bye")
        {

            if (timer > 100)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];
            }
            timer += 1;


        }
        else if (intent == "Yes")
        {


            if (timer > 100)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];
            }
            timer += 1;

        }
        else if (intent == "No")
        {



            if (timer > 100)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];
            }
            timer += 1;

        }
        else if (intent == "ConditionOfILo")
        {
            


            if (timer > 500) 
                {
                    timer = 0;
                    intent = "";
                }
            if ((timer % 500) == 0)
            {
                rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];
            }
            timer += 1;


        }
        else if (intent == "ThankYou")
        {



            if (timer > 500)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];
            }
            timer += 1;


        }
        
        else if (intent == "LifeConditionILo")
        {

            if (timer > 500)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];

            }
            timer += 1;

        }
        else if (intent == "DefinitionCymry")
        {

            if (timer > 1800)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];

            }
            timer += 1;

        }
        else if (intent == "DefinitionSymptomatology")
        {

            if (timer > 2100)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];

            }
            timer += 1;

        }
        else if (intent == "DefinitionSymptomatology")
        {

            if (timer > 2500)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];

            }
            timer += 1;

        }
        else if (intent == "DefinitionBiotaxy")
        {

            if (timer > 2500)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];

            }
            timer += 1;

        }
        else if (intent == "DefinitionHendecagon")
        {

            if (timer > 1900)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];

            }
            timer += 1;

        }
        else if (intent == "DefinitionExodontist")
        {

            if (timer > 1500)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];

            }
            timer += 1;

        }
        else if (intent == "ChangeBooks")
        {

            if (timer > 800)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];

            }
            timer += 1;

        }
        else if (intent == "ChangeKitchen")
        {

            if (timer > 700)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];

            }
            timer += 1;

        }
        else if (intent == "VerbalJoke")
        {

            if (timer > 1200)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];

            }
            timer += 1;

        }
        else if (intent == "VerbalMusic")
        {

            if (timer > 100)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                rend.material.mainTexture = textures[Random.Range(7, 8)];

            }
            timer += 1;

        }
        else if (intent == "GetInstruction")
        {



            if (timer > 23500)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];
            }


        }
        timer += 1;







    }




    //=====================================================
    // mini animation manager
    //=====================================================
    void ChangeAnimationState(string newAnimation)
    {
        if (currentAnimaton == newAnimation) return;

        animator.Play(newAnimation);
        currentAnimaton = newAnimation;
    }
    //=====================================================
    //Get Intent from Rhasspy
    //=====================================================
    public void GetIntend(object sender, MessageEventArgs e)
    {

        char[] delimiterChars = { ' ', ',', '.', ':', '"', '{', '}' };
        string[] words = e.Data.Split(delimiterChars);
        string word = words[11];
        Debug.Log("Data: " + word);
        intent = word;
    }

    private bool isLocation()
    {
        GameObject Destination = GameObject.Find("I-Lo-Destination");
        if(transform.position.x == Destination.transform.position.x && transform.position.z == Destination.transform.position.z)
        {
            return true;
        }
        return false;
    }



}
