using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using WebSocketSharp;

public class I_Lo_Script : MonoBehaviour
{
    //Websocket
    WebSocket ws;
    string intent;


    [SerializeField]

    private Animator animator;
    private string currentAnimaton;


    [SerializeField]


    //Animation States

    const string Idle = "Idle";
    const string Forward = "Forward";

    const string Hi = "Hello";
    const string Both = "Both45";
    const string Point = "Point45";

    const string Head_Up = "Head_up";
    const string Head_Down = "Head_down";
    const string HeadRight_1 = "HeadRight_1";
    const string HeadRight_2 = "HeadRight_2";
    const string HeadLeft_1 = "HeadLeft_1";
    const string HeadLeft2 = "HeadLeft_2";

    const string Left_90 = "LeftArm_90";
    const string Left_45 = "LeftArm_45";

    const string Wave = "RightArm_Wave";
    const string Right_90 = "RightArm_90";
    const string Right_45 = "RightArm_45";
    const string Right_Point = "RightArm_Point";

    string[] gestures = { Left_45, Right_45, Right_Point, HeadRight_1, HeadLeft_1, Both, Point};


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


        //Animations

        if (ws == null)
        {
            return;
        }
        else if (intent == "Hello")
        {
            timer += 1;
            if (timer < 600)
            {
                animator.Play(Hi);
            }
            else
            {
                animator.Play(Head_Down);
                timer = 0;
                intent = "";
            }
        



        }
        else if (intent == "Bye")
        {
            timer += 1;
            if (timer < 600)
            {
                animator.Play(Hi);
            }
            else
            {
                animator.Play(Head_Down);
                timer = 0;
                intent = "";
            }




        }
        /*else if (intent == "Yes")
        {
            timer += 1;
            if (timer < 100 && timer > 0)
            {
                animator.Play(Head_Up);
            }
            else if(timer < 200 && timer > 100)
            {
                animator.Play(Head_Down);

            }
            else if (timer < 300 && timer > 200)
            {
                animator.Play(Head_Up);

            }
            else if(timer > 300)
            {
                animator.Play(Head_Down);
                timer = 0;
                intent = "";
            }




        }
        else if (intent == "No")
        {
            timer += 1;
            if (timer < 300 && timer > 0)
            {
                animator.Play(HeadRight_1);
            }
            else if(timer < 600 && timer > 300)
            {
                animator.Play(HeadLeft_1);

            }
            else if(timer > 600)
            {
                animator.Play(HeadRight_1);
                timer = 0;
                intent = "";
            }




        }
        */
        else if (intent == "ThankYou")
        {


            print(timer);


            if (timer > 500)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                animator.Play(gestures[Random.Range(0, gestures.Length)]);
            }
            timer += 1;



        }
        else if (intent == "ChangeBooks")
        {

            print(timer);


            if (timer > 800)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                animator.Play(gestures[Random.Range(0, gestures.Length)]);
            }
            timer += 1;



        }
        else if (intent == "ChangeKitchen")
        {


            print(timer);


            if (timer > 700)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                animator.Play(gestures[Random.Range(0, gestures.Length)]);
            }
            timer += 1;


        }
        else if (intent == "ConditionOfILo")
        {


            print(timer);


            if (timer > 500) 
                {
                    timer = 0;
                    intent = "";
                }
            if ((timer % 500) == 0)
            {
                animator.Play(gestures[Random.Range(0, gestures.Length)]);
            }
            timer += 1;

        }
        else if (intent == "LifeConditionILo")
        {

            print(timer);


            if (timer > 800)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                animator.Play(gestures[Random.Range(0, gestures.Length)]);
            }
            timer += 1;

        }
        else if (intent == "DefinitionCymry")
        {

            print(timer);


            if (timer > 1800)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                animator.Play(gestures[Random.Range(0, gestures.Length)]);
            }
            timer += 1;

        }
        else if (intent == "DefinitionBindery")
        {

            print(timer);


            if (timer > 2100)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                animator.Play(gestures[Random.Range(0, gestures.Length)]);
            }
            timer += 1;

        }
        else if (intent == "DefinitionSymptomatology")
        {

            print(timer);


            if (timer > 2500)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                animator.Play(gestures[Random.Range(0, gestures.Length)]);
            }
            timer += 1;

        }
        else if (intent == "DefinitionBiotaxy")
        {

            print(timer);


            if (timer > 2500)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                animator.Play(gestures[Random.Range(0, gestures.Length)]);
            }
            timer += 1;

        }
        else if (intent == "DefinitionHendecagon")
        {

            print(timer);


            if (timer > 1900)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                animator.Play(gestures[Random.Range(0, gestures.Length)]);
            }
            timer += 1;

        }
        else if (intent == "DefinitionExodontist")
        {

            print(timer);


            if (timer > 1500)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                animator.Play(gestures[Random.Range(0, gestures.Length)]);
            }
            timer += 1;

        }
        else if (intent == "VerbalJoke")
        {

            print(timer);


            if (timer > 1200)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                animator.Play(gestures[Random.Range(0, gestures.Length)]);
            }
            timer += 1;

        }
        else if (intent == "VerbalMusic")
        {

            print(timer);


            if (timer > 2500)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                animator.Play(gestures[Random.Range(0, gestures.Length)]);
            }
            timer += 1;

        }
        else if (intent == "GetInstruction")
        {

            print(timer);



            if (timer > 21500)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 500) == 0)
            {
                animator.Play(gestures[Random.Range(0, gestures.Length)]);
            }
            timer += 1;

        }

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
