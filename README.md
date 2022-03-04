# I-Lo

## Table of Files(!):
- MP3 -> These are the sound files of what I-Lo is sayingc dependent on the conditions (if you do not use  Rhasspy's in-build text-to-speech converter)
- Node-RED/flows.json -> this is an example flow without the audio files and instead the usage of Rhasspy's in-build text-to-speech converter
- Node-RED/MP3_Flow.json -> this is the flow we used to play the audios in Node-Red
- Node-RED/With_Yes_No.json -> this is an example for an advanced flow for Node-Red with not only text-to-speech but also the option immediately answering one of I-Lo's questions without using the wake word
- Documentation.txt -> Here you can read everything in more detail, especially with 
- I-Lo.zip -> this includes everything we used except for opensourced assets from the Unity Asset store
- README.md -> this is what you are currently reading
- all_introductions.txt -> these are the different introductions I-Lo has for the different conditions
- rhasspy_sentences.txt -> here you can find our Rhasspy sentences and word pronounciations

## The idea
Following a human-robot interaction course at the University Osnabruck, we conducted this first approach of a study on **whether a robot evokes a stronger feeling of trustworthiness and integrity than a speech assistant** and **whether there are characteristics which influence these feelings**.
We wanted to improve the experience one has with speech assistants such as 'Alexa' and 'Siri' and came to the conclusion, that we would really like to have a small robot talking to us and maybe even gesturing.
Following this, we decided, that having a robot converse more with you than the normal speech assistant would be an interesting trait to evaluate, same as seeing how gestures influence the participant. We thought, participants would find these traits more human-like, so they should be making a difference in the way they act around the robot.

To see an interaction between human and speech assistant, we wanted the participants to complete different tasks within a homely environment. These tasks were supposed to be 
varying in dependency on the speech assistant, e.g. some were definitions one had to ask the speech assistant for, some were managable without.

Since we do not have neither the KNOWHOW nor the hardware and financial capabilities we decided to conduct the study in a virtual environment.
Also we wanted to create our own brand for speech assistants, independent of them being stationary or mobile (also to not get any legal problems^^).


## What we did
This was the beginning of a tale, the tale of I-Lo: I-Lo is our version of a speech assistant, which is also available as a robot.

We decided to have four different Conditions for the robot:
- the normal speech assistant, who just gives you the needed information
- the normal speech assistant, who just gives you the needed information with gestures
- the converstational speech assistant, which was more friendly and gave more information
- the converstational speech assistant, which was more friendly and gave more information with gestrues

The stationary speech assistant only had the normal speech assistant condition.

The experiment itself consistet of two parts. After having a short introduction and familiarisation phase, the participants were brought into the scene twice and were asked to fill out a questionaire after each session. These two sessions differed in the form of the speech assistant (stationary or robot), where the robot's conditions were randomly assigned, and the tasks the participant was supposed to complete.

While the participants were in the virtual environment, we took notes on how they acted around I-Lo. Specifically, we paid attention to the participants' line of vision, since them looking at the speech assistant is an indicator for them to respect and therefore trust it.

Since we had some perfomrance issues, we did not do this via eyetracking. Also we had to cut the connection between the virtual environment and the speech assistant. We used two computer, one having the virtual environment, the other having the audio input and output. This lead to us having to activate the correct animations in the virtual environment manually by pressing keys.

The collected data were evaluated and visualised with diagrams.

## What we used
*To have a functioning I-Lo, we first needed the bodies of the speech assistant and robot we were going to put into our Unity repository.*

### [Unity](https://unity.com)
Unity is a cross-platform game engine developed by Unity Technologies, which can be used to create three-dimensional (3D) and two-dimensional (2D) games
as well as interactive simulations and other experiences.

For our purpose we created a homely environment with the help of some opensourced assets [1]. This consisted of a furnished cabin in which the participants were able to interact with a version of I-Lo and some objects such as books and kitchen utensils.

The version we used for this project is 2020.3.12f1.

*The bodies for I-Lo were build in Blender and transferred to Unity via fbx-files including animations for the robot.*

### [Blender](https://www.blender.org)
 Blender is a free and open-source 3D computer graphics software toolset with features including 3D modelling, UV unwrapping, texturing, soft body simulation, sculpting, animating and rendering.
 The version we used for this project is 2.93.1.
 
 We created a robot and a cylindrical body with textures for the speech assistant and did the animations for the robot body.

*With this we covered I-Lo's physique and movement, but it still did not contain the conversational part.
Hence, we decided to use Rhasspy.*

### [Rhasspy](https://github.com/synesthesiam/rhasspy)
Rhasspy is an opensourced, fully offline usable voice assistant tool-kit, which you can use to build your own smart home.
It works similar to known speech assistants such as 'Alexsa' or'Siri' with a wake word and has in-build speech-to-text and text-to-speech converter.
Rhasspy takes the audio input, converts it to text and compares it to beforhand computed intents.
An example for an intent in Rhasspy would be:

[GetInstruction] <- the intent name
instructions                                               |
give ([me]|[some]) instructions                            |said text expected for this intent
([can]|[could]) you give [me] some instructions            |

When an intent is recognized, Rhasspy needs to get information from another sofware/source on what to do. These are normally the answers in text form, which are converted back to speech. 

 *To get these desired answers, we combined Rhasspy with Node-RED.*


### [Node-RED](https://nodered.org)
Node-RED is a programming tool for wiring together hardware devices, APIs and online services and provides a browser-based editor that makes it easy to wire together flows using a wide range of nodes. 
As you can see, you can do a lot of different things, such as controlling lights or having an audio output, but also giving back a text to a text-to-speech converter, which we wanted to use, but had to circumvent this due to performance issues and us preferring a different voice.

In the end, our flow consisted of the different conditions and the suitable audios from teh MP3 folder, which were played given the intent recognised by Rhasspy.



## How to work with this
First and formost: Please read through the documentation for more detailed information and some of our ideas for improvement.

If you installed all the sofware needed, we would recommend to first implement your chosen flow to Node-RED and your chosen intents to Rhasspy. Be aware that you might want to implement the pronounciations at the bottom of the rhasspy_sentences.txt file as well.

If you want to use the MP3_Flow in Node-RED, please change the paths according to the location of your audios.

When opening Unity 
get I-Lo's robot body and put the arms and gead as its children, then drag the body scipt into the body and the I-Lo script into the arms and head
materials!
make an object and put into it the !Rhasspy_connect scriptand connect this object with the I-Lo body via Player Nav Mesh!
To not have the robot go through any furniture, we would recommend you to define the area over the navigation tab on the I-Lo body in which I-Lo will move via the Nav mesh agent.
for I-Lo's stationary body, put the speech assistant script into there


To get Rhasspy's intent directly into unity we used the package “websocketsharp-net standard” in the beginning which you can install via the Asset “NuGet” in Unity. You can use this package in a Script and filter the intent from the JSON String you get from Rhasspy.

https://myshare.uni-osnabrueck.de/d/034e81fbff524338a1d9/

## Data references / Credits
[1]: Unity
https://unity.com

[2]: Opensourced Asstes Unity:

The Cabin: 
https://assetstore.unity.com/packages/3d/environments/urban/furnished-cabin-71426

Plants: 
https://assetstore.unity.com/packages/3d/vegetation/plants/plants-150261
https://assetstore.unity.com/packages/3d/environments/low-poly-free-vegetation-kit-176906

Books: 
https://assetstore.unity.com/packages/3d/props/interior/qa-books-115415

Kitchen Utensils: 
https://assetstore.unity.com/packages/3d/props/interior/meat-hammer-pbr-129061
https://assetstore.unity.com/packages/3d/props/interior/pbr-ladle-129004
https://assetstore.unity.com/packages/3d/props/interior/plates-bowls-mugs-pack-146682

[3]: Blender
https://www.blender.org

[4]: Rhasspy
Github Repository Version 2.4: 
https://github.com/synesthesiam/rhasspy

Rhasspy Installation Guide 2.4:
https://rhasspy.readthedocs.io/en/v2.4.20/installation/

[5] Node-RED
https://nodered.org/



## A last word (!!!)

If you are interested in this study or want to conduct a similar study, we would be happy to hear you approaches towards this.
