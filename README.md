# I-Lo

## Table of Files(!):
- MP3 -> These are the sound files of what I-Lo is sayingc dependent on the conditions (if you do not use  Rhasspy's in-build text-to-speech converter)
- Node-RED/flows.json -> this is the flow we used with the above mentioned sound files
- Node-RED/MP3_Flow.json -> this is the flow we used to play the audios in Node-Red
- Node-RED/With_Yes_No.json -> this is an example for an advanced flow for Node-Red with not only text-to-speech but also the option immediately answering one of I-Lo's questions without using the wake word
- Documentation.txt -> Here you can read everything in more detail, especially with 
- I-Lo.zip -> this includes the bodies for the speech assistants, (C#-)scripts, animation and all further assets
- README.md -> this is what you are currently reading
- all_introductions.txt -> these are the different introductions I-Lo has for the different conditions
- rhasspy_sentences.txt -> here you can find our Rhasspy sentences and word pronounciations

## The idea !!!!?
Following a human-robot interaction course at the University osnabruck, we conducted this first approach of a study on **whether a robot evokes a stronger feeling of trustworthiness and integrity than a speech assistant** and **whether there are characteristics which influence these feelings**.
We wanted to improve the experience one has with speech assistants such as 'Alexa' and 'Siri' and came to the conclusion, that we would really like to have a small robot talking and maybe even gesturing to us.

Since we do not have neither the KNOWHOW nor the 'hardware and financial capabilities'/assets (?) we decided to conduct the study in a virtual environment.
Also we wanted to create our own brand for speech assistants, independent of them being stationary or mobile.

This was the beginning of a tale, the tale of I-Lo: I-Lo is our version of a speech assistant, which is also available as a robot.

## What we did
- not really assistive, since we agreed from the very start, that any further assistance was a too big work load for the amount of time we were given (e.g. no carrying around)
- the experiment itself consistet of two parts: 3 conditions;  
- perfomrance issues (keys, two pc)

## What we used
*To have a functioning I-Lo, we first needed the bodies of the speech assistant and robot we were going to put into our Unity repository.*

### [Unity](https://unity.com)
Unity is a cross-platform game engine developed by Unity Technologies, which can be used to create three-dimensional (3D) and two-dimensional (2D) games
as well as interactive simulations and other experiences.

For our purpose we created a homely environment with the help of some opensourced assets[1]. This consisted of a furnished cabin in which the participants were able to interact with a version of I-Lo and some devices(?) such as books or kitchen utensils.

The version we used for this project is 2020.3.12f1.

*The bodies for I-Lo were build in Blender and transferred to Unity via a fbx-files including animations for the robot.*

### [Blender](https://www.blender.org)
 Blender is a...
 The version we used for this project 

*With this we covered I-Lo's physique and movement, but did not contain the conversational part.
Hence, we decided to use Rhasspy.*

### [Rhasspy](https://github.com/synesthesiam/rhasspy)
Rhasspy is an opensourced, fully offline usable voice assistant tool-kit, which you can use to build your own smart home.
It works similar to known speech assistants such as 'Alexsa' or'Siri' with a wake word and has in-build speech-to-text and text-to-speech converter.
Rhasspy takes the audio input, converts it to text and compares it to beforhand computed intents.
An example for an intent in Rhasspy would be:
...

When an intent is recognized, Rhasspy needs to get information from another sofware/program/source (?) on what to do. These are normally the answers in text form, which are converted to speech. 

 *To get these desired answers, we combined Rhasspy with Node-Red.*


### [Node-RED](https://nodered.org)
Node-RED is a programming tool for wiring together hardware devices, APIs and online services and provides a browser-based editor that makes it easy to wire together flows using a wide range of nodes. As you can see, you can do a lot of different things, such as controlling lights or having an audio output, but also giving back a text to a text-to-speech converter, which we wanted to use.

In the end, our flow consisted of the different conditions and the suitable audios, which were played given the intent recognised by Rhasspy.


## How to work with this
First and formost: Please read through the documentation for more detailed information and some of our ideas for improvement.

If you installed all the sofware needed, we would recommend to first implement your chosen flow to Node-RED and your chosen intents to Rhasspy. Be aware that you might want to implement the pronounciations at the bottom of the rhasspy_sentences.txt file as well.
Node-RED:
- if you want to use the MP3_Flow in Node-RED, please change the paths according to the location of your audios
Unity:
- you would need to get the websocket from Rhasspy to get the intent and can therefore say 


https://myshare.uni-osnabrueck.de/d/034e81fbff524338a1d9/

## Data references / Credits
[1] 
Github Repository Version 2.4: 
https://github.com/synesthesiam/rhasspy

Rhasspy Installation Guide 2.4:
https://rhasspy.readthedocs.io/en/v2.4.20/installation/
Website: https://nodered.org/


Project data Unity:
https://myshare.uni-osnabrueck.de/d/034e81fbff524338a1d9/

## A last word (!!!)

If you are interested in this study or want to conduct a similar study, we would be happy to hear you approaches towards this.
