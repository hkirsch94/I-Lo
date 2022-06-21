using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speech_Assistant : MonoBehaviour
{

    // Update is called once per frame

        string intent;

        //Texture
        public List<Texture2D> textures = new List<Texture2D>();
        public Renderer rend1;
        public Renderer rend2;

        //Music
        public AudioSource music;
        public List<AudioClip> text;


        int timer = 0;

    //=====================================================
    // Start is called before the first frame update
    //=====================================================
        void Start()
            {

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
                intent = "Bye";
            }
            else if (Input.GetKey("t"))
            {
                intent = "ThankYou";
            }
            else if (Input.GetKey("o"))
            {
                intent = "ChangeBooks";
            }
            else if (Input.GetKey("o"))
            {
                intent = "GoCharge";
            }
            else if (Input.GetKey("u"))
            {
                intent = "ChangeKitchen";
            }
            else if (Input.GetKey("n"))
            {
                intent = "ConditionOfILo";
            }
            else if (Input.GetKey("l"))
            {
                intent = "LifeConditionILo";
            }
            else if (Input.GetKey("c"))
            {
                intent = "DefinitionCymry";
            }
            else if (Input.GetKey("d"))
            {
                intent = "DefinitionBindery";
            }
            else if (Input.GetKey("s"))
            {
                intent = "DefinitionSymptomatology";
            }
            else if (Input.GetKey("t"))
            {
                intent = "DefinitionBiotaxy";
            }
            else if (Input.GetKey("h"))
            {
                intent = "DefinitionHendecagon";
            }
            else if (Input.GetKey("x"))
            {
                intent = "DefinitionExodontist";
            }
            else if (Input.GetKey("j"))
            {
                intent = "VerbalJoke";
            }
            else if (Input.GetKey("m"))
            {
                intent = "VerbalMusic";
            }
            else if (Input.GetKey("i"))
            {
                intent = "GetInstruction";
            }
            else if (Input.GetKey("y"))
            {
                intent = "";
                timer = 0;
            }


            //Animations

        if (intent == "Hello")
        {


            if (timer > 100)
            {
                timer = 0;
                intent = "";
                rend1.material.mainTexture = textures[0];
                rend2.material.mainTexture = textures[0];
            }
            else if ((timer % 100) == 0)
            {
                rend1.material.mainTexture = textures[Random.Range(1, textures.Count)];
                rend2.material.mainTexture = textures[Random.Range(1, textures.Count)];

            }

            timer += 1;

        }
        else if (intent == "Bye")
        {

            if (timer > 100)
            {
                timer = 0;
                intent = "";
                rend1.material.mainTexture = textures[0];
                rend2.material.mainTexture = textures[0];
            }
            else if ((timer % 100) == 0)
            {
                rend1.material.mainTexture = textures[Random.Range(1, textures.Count)];
                rend2.material.mainTexture = textures[Random.Range(1, textures.Count)];
            }

            timer += 1;

        }
        else if (intent == "Yes")
        {


            if (timer > 100)
            {
                timer = 0;
                intent = "";
                rend1.material.mainTexture = textures[0];
                rend2.material.mainTexture = textures[0];
            }
            else if ((timer % 100) == 0)
            {
                rend1.material.mainTexture = textures[Random.Range(1, textures.Count)];
                rend2.material.mainTexture = textures[Random.Range(1, textures.Count)];
            }

            timer += 1;

        }
        else if (intent == "No")
        {



            if (timer > 100)
            {
                timer = 0;
                intent = "";
                rend1.material.mainTexture = textures[0];
                rend2.material.mainTexture = textures[0];
            }
            else if ((timer % 100) == 0)
            {
                rend1.material.mainTexture = textures[Random.Range(1, textures.Count)];
                rend2.material.mainTexture = textures[Random.Range(1, textures.Count)];
            }

            timer += 1;

        }
        else if (intent == "ConditionOfILo")
        {



            if (timer > 100)
            {
                timer = 0;
                intent = "";
                rend1.material.mainTexture = textures[0];
                rend2.material.mainTexture = textures[0];
            }
            else if ((timer % 100) == 0)
            {
                rend1.material.mainTexture = textures[Random.Range(1, textures.Count)];
                rend2.material.mainTexture = textures[Random.Range(1, textures.Count)];
            }

            timer += 1;


        }
        else if (intent == "ThankYou")
        {



            if (timer > 100)
            {
                timer = 0;
                intent = "";
                rend1.material.mainTexture = textures[0];
                rend2.material.mainTexture = textures[0];
            }
            else if ((timer % 100) == 0)
            {
                rend1.material.mainTexture = textures[Random.Range(1, textures.Count)];
                rend2.material.mainTexture = textures[Random.Range(1, textures.Count)];
            }

            timer += 1;


        }

        else if (intent == "LifeConditionILo")
        {

            if (timer > 500)
            {
                timer = 0;
                intent = "";
                rend1.material.mainTexture = textures[0];
                rend2.material.mainTexture = textures[0];
            }
            else if ((timer % 100) == 0)
            {
                rend1.material.mainTexture = textures[Random.Range(1, textures.Count)];
                rend2.material.mainTexture = textures[Random.Range(1, textures.Count)];
            }

            timer += 1;

        }
        else if (intent == "DefinitionCymry")
        {

            if (timer > 1500)
            {
                timer = 0;
                intent = "";
                rend1.material.mainTexture = textures[0];
                rend2.material.mainTexture = textures[0];
            }
            else if ((timer % 100) == 0)
            {
                rend1.material.mainTexture = textures[Random.Range(1, textures.Count)];
                rend2.material.mainTexture = textures[Random.Range(1, textures.Count)];
            }

            timer += 1;

        }
        else if (intent == "DefinitionBindery")
        {

            if (timer > 2500)
            {
                timer = 0;
                intent = "";
                rend1.material.mainTexture = textures[0];
                rend2.material.mainTexture = textures[0];
            }
            else if ((timer % 100) == 0)
            {
                rend1.material.mainTexture = textures[Random.Range(1, textures.Count)];
                rend2.material.mainTexture = textures[Random.Range(1, textures.Count)];
            }

            timer += 1;

        }
        else if (intent == "DefinitionSymptomatology")
        {

            if (timer > 1500)
            {
                timer = 0;
                intent = "";
                rend1.material.mainTexture = textures[0];
                rend2.material.mainTexture = textures[0];
            }
            else if ((timer % 100) == 0)
            {
                rend1.material.mainTexture = textures[Random.Range(1, textures.Count)];
                rend2.material.mainTexture = textures[Random.Range(1, textures.Count)];
            }

            timer += 1;

        }

        else if (intent == "DefinitionBiotaxy")
        {

            if (timer > 2500)
            {
                timer = 0;
                intent = "";
                rend1.material.mainTexture = textures[0];
                rend2.material.mainTexture = textures[0];
            }
            else if ((timer % 100) == 0)
            {
                rend1.material.mainTexture = textures[Random.Range(1, textures.Count)];
                rend2.material.mainTexture = textures[Random.Range(1, textures.Count)];
            }

            timer += 1;

        }
        else if (intent == "DefinitionHendecagon")
        {

            if (timer > 200)
            {
                timer = 0;
                intent = "";
                rend1.material.mainTexture = textures[0];
                rend2.material.mainTexture = textures[0];
            }
            else if ((timer % 100) == 0)
            {
                rend1.material.mainTexture = textures[Random.Range(1, textures.Count)];
                rend2.material.mainTexture = textures[Random.Range(1, textures.Count)];
            }

            timer += 1;

        }
        else if (intent == "DefinitionExodontist")
        {

            if (timer > 1500)
            {
                timer = 0;
                intent = "";
                rend1.material.mainTexture = textures[0];
                rend2.material.mainTexture = textures[0];
            }
            else if ((timer % 100) == 0)
            {
                rend1.material.mainTexture = textures[Random.Range(1, textures.Count)];
                rend2.material.mainTexture = textures[Random.Range(1, textures.Count)];
            }

            timer += 1;

        }
        else if (intent == "ChangeBooks")
        {

            if (timer > 500)
            {
                timer = 0;
                intent = "";
                rend1.material.mainTexture = textures[0];
                rend2.material.mainTexture = textures[0];
            }
            else if ((timer % 100) == 0)
            {
                rend1.material.mainTexture = textures[Random.Range(1, textures.Count)];
                rend2.material.mainTexture = textures[Random.Range(1, textures.Count)];
            }

            timer += 1;

        }
        else if (intent == "ChangeKitchen")
        {

            if (timer > 500)
            {
                timer = 0;
                intent = "";
                rend1.material.mainTexture = textures[0];
                rend2.material.mainTexture = textures[0];
            }
            else if ((timer % 100) == 0)
            {
                rend1.material.mainTexture = textures[Random.Range(1, textures.Count)];
                rend2.material.mainTexture = textures[Random.Range(1, textures.Count)];
            }

            timer += 1;

        }
        else if (intent == "VerbalJoke")
        {


            if (timer > 1000)
            {
                timer = 0;
                intent = "";
                rend1.material.mainTexture = textures[0];
                rend2.material.mainTexture = textures[0];
            }
            else if ((timer % 100) == 0)
            {
                rend1.material.mainTexture = textures[Random.Range(1, textures.Count)];
                rend2.material.mainTexture = textures[Random.Range(1, textures.Count)];
            }

            timer += 1;

        }
        else if (intent == "VerbalMusic")
        {

            if (timer > 500)
            {
                timer = 0;
                intent = "";
                rend1.material.mainTexture = textures[0];
                rend2.material.mainTexture = textures[0];
            }
            else if ((timer % 100) == 0)
            {
                rend1.material.mainTexture = textures[Random.Range(1, textures.Count)];
                rend2.material.mainTexture = textures[Random.Range(1, textures.Count)];
            }

            timer += 1;

        }
        else if (intent == "GetInstruction")
        {

            if (timer > 28000)
            {
                timer = 0;
                intent = "";
                rend1.material.mainTexture = textures[0];
                rend2.material.mainTexture = textures[0];
            }
            else if ((timer % 100) == 0)
            {
                rend1.material.mainTexture = textures[Random.Range(1, textures.Count)];
                rend2.material.mainTexture = textures[Random.Range(1, textures.Count)];
                print("random" + timer);
            }

            timer += 1;


        }

    }

}
