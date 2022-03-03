# I-Lo

## Table of Files:
- MP3 -> These are the sound files of what I-Lo is saying (if you do not use  Rhasspy's inbuild text-to-speech converter)
- documentation.txt -> Here you can read everything in more detail, especially with 
- I-Lo.zip -> this includes the body, all (C#-)scrips, animation
- MP3_Flow.json -> this is the flow we used to play the audios in Node-Red
- README.md -> This is what you are currently reading
- With_Yes_No.json -> this is an example for an advanced flow for Node-Red with not only text-to-speech but also the option immediately answering one of I-Lo's questions without using the wake word
- all_introductions.txt -> these are the different introductions I-Lo has for the different conditions
- flows.json -> this is the flow we used with the above mentioned sound files
- rhasspy_sentences.txt -> here you can find our Rhasspy sentences and word pronounciations

## The idea !!!!?
Following a human-robot interaction course at the University osnabruck, we conducted this first approach of a study on **whether a robot evokes a stronger feeling of trustworthiness and integrity than a speech assistant** and **whether there are characteristics which influence these feelings**.
Since robots are already used as Social Bots or assistive robots we were interested in a combination of this which one can have at home. 
First thing which came to mind were speech assistants such as 'Siri' or 'Alexa', so we thought of a way to improve the experience.

Since we do not have neither the KNOWHOW nor the 'hardware and financial capabilities'/assets (?) we decided to conduct the study in a virtual environment.
Also we wanted to create our own brand for speech assistants, independent of them being stationary or mobile.

I-Lo was born: I-Lo is our version of a speech assistant, which is also available as a robot.

## What we used
*To have a functioning I-Lo, we first needed the bodies of the speech assistant and robot we were going to put into our Unity repository.*

### [Unity](https://unity.com)
Unity is a cross-platform game engine developed by Unity Technologies, which can be used to create three-dimensional (3D) and two-dimensional (2D) games
as well as interactive simulations and other experiences.

For our purpose we created a homely environment with the help of some opensourced assets[1]. This consited of a 
The version we used for this project is 2020.3.12f1.

*The bodies for I-Lo were build in Blender and transferred to Unity via a fbx-files including animations for the robot.*

### [Blender](https://www.blender.org)
 Blender is a...
 The version we used for this project 

With this we covered I-Lo's physique and movement, but did not contain the conversational part.
Hence, we decided to use Rhasspy

### [Rhasspy](https://github.com/synesthesiam/rhasspy)
Rhasspy is an opensourced, fully offline usable voice assistant tool-kit, which you can use to build your own smart home.
It works similar to known speech assistants such as 'Alexsa' or'Siri' with a wake word and has in-build speech-to-text and text-to-speech converter to have a conversation.


Github Repository Version 2.4: 
https://github.com/synesthesiam/rhasspy

Rhasspy Installation Guide 2.4:
https://rhasspy.readthedocs.io/en/v2.4.20/installation/

 *To get the desired answers, we combined Rhasspy with Node-Red.*


### [Node_Red](https://nodered.org)
Node_red is
Website: https://nodered.org/


Project data Unity:
https://myshare.uni-osnabrueck.de/d/034e81fbff524338a1d9/

## How to work with this
First and formost: Please read through the documentation for more detailed information and some of our ideas for improvement.

https://myshare.uni-osnabrueck.de/d/034e81fbff524338a1d9/

## Data references / Credits
[1] 

## A last word
