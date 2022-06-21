using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class I_Lo_Script_Body : MonoBehaviour
{
    string intent;



    //Texture
    public List<Texture2D> textures = new List<Texture2D>();
    public List<Texture2D> talkFaces = new List<Texture2D>();
    public Renderer rend;
   
    //Music
    public AudioSource music;
    public List<AudioClip> text;
    
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


    }

    //=====================================================
    // Update is called once per frame
    //=====================================================
    void Update()
    {
        
        if (Input.GetKey("a"))
        {
            intent = "Hello";
        }
        else if (Input.GetKey("z"))
        {
            intent = "Bye" ;
        }
        else if (Input.GetKey("t"))
        {
            intent = "ThankYou" ;
        }else if (Input.GetKey("o"))
        {
            intent = "ChangeBooks";
        }
        else if (Input.GetKey("p"))
        {
            intent = "GoCharge";
        }
        else if (Input.GetKey("u"))
        {
            intent = "ChangeKitchen" ;
        }
        else if (Input.GetKey("n"))
        {
            intent = "ConditionOfILo" ;
        }
        else if (Input.GetKey("l"))
        {
            intent = "LifeConditionILo" ;
        }
        else if (Input.GetKey("c"))
        {
            intent = "DefinitionCymry" ;
        }
        else if (Input.GetKey("d"))
        {
            intent = "DefinitionBindery" ;
        }
        else if (Input.GetKey("s"))
        {
            intent = "DefinitionSymptomatology" ;
        }
        else if (Input.GetKey("t"))
        {
            intent = "DefinitionBiotaxy" ;
        }
        else if (Input.GetKey("h"))
        {
            intent = "DefinitionHendecagon" ;
        }
        else if (Input.GetKey("x"))
        {
            intent = "DefinitionExodontist" ;
        }
        else if (Input.GetKey("j"))
        {
            intent = "VerbalJoke" ;
        }
        else if (Input.GetKey("m"))
        {
            intent = "VerbalMusic" ;
        }
        else if (Input.GetKey("i"))
        {
            intent = "GetInstruction" ;
        }
        else if (Input.GetKey("left shift"))
        {
            rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];
            timer = 0;
        }
        else if (Input.GetKey("y"))
        {
            intent = "";
            timer = 0;
        }

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

        if (intent == "Hello")
        {

            timer += 1;

            if (timer > 6000)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 300) == 0)
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
            if ((timer % 300) == 0)
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
            if ((timer % 300) == 0)
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
            if ((timer % 300) == 0)
            {
                rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];
            }
            timer += 1;

        }
        else if (intent == "ConditionOfILo")
        {
            


            if (timer > 100)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 300) == 0)
            {
                rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];
            }
            timer += 1;


        }
        else if (intent == "ThankYou")
        {



            if (timer > 100)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 300) == 0)
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
            if ((timer % 300) == 0)
            {
                rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];

            }
            timer += 1;

        }
        else if (intent == "DefinitionCymry")
        {

            if (timer > 1500)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 300) == 0)
            {
                rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];

            }
            timer += 1;

        }
        else if (intent == "DefinitionBindery")
        {

            if (timer > 2500)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 300) == 0)
            {
                rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];

            }
            timer += 1;

        }
        else if (intent == "DefinitionSymptomatology")
        {

            if (timer > 1500)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 300) == 0)
            {
                rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];

            }
            timer += 1;

        }
        else if (intent == "DefinitionBiotaxy")
        {

            if (timer > 3000)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 300) == 0)
            {
                rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];

            }
            timer += 1;

        }
        else if (intent == "DefinitionHendecagon")
        {

            if (timer > 1800)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 300) == 0)
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
            if ((timer % 300) == 0)
            {
                rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];

            }
            timer += 1;

        }
        else if (intent == "ChangeBooks")
        {

            if (timer > 500)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 300) == 0)
            {
                rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];

            }
            timer += 1;

        }
        else if (intent == "ChangeKitchen")
        {

            if (timer > 500)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 300) == 0)
            {
                rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];

            }
            timer += 1;

        }
        else if (intent == "VerbalJoke")
        {
            
            if (timer > 1000)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 300) == 0)
            {
                rend.material.mainTexture = talkFaces[Random.Range(0, talkFaces.Count)];

            }
            
            timer += 1;

        }
        else if (intent == "VerbalMusic")
        {

            if (timer > 500)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 300) == 0)
            {
                rend.material.mainTexture = textures[Random.Range(7, 8)];

            }
            timer += 1;

        }
        else if (intent == "GetInstruction")
        {



            if (timer > 28000)
            {
                timer = 0;
                intent = "";
            }
            if ((timer % 300) == 0)
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
