# VR_Game_Project3
This project is focused on learning to code the scripts that bring everything to life. Skills include:

1. Creating new C# scripts in Unity
2. If then, loops, arrays, and other programming constructs
3. Attaching scripts to objects
4. Using the built-in Monobehaviour methods
5. Triggers and Gaze Based Interaction
6. Creating, moving and animating objects procedurally
7. Familiarization with the Unity documentation
8. Scripting Dynamic UI Objects
9. Debugging
10. The Unity Event System.
11. Managing and Reloading scenes.
12. Controlling particle systems.
13. Create an Audio Clip and playing sounds.
14. Waypoint Navigation System.
15. Profiling scenes for performance.

Viewing MY App On a Device (Android or IOS)
=================================================================================

1. Screenshot of Unity app running on phone
2. Successful build of the app (apk file for Android and XCode project for iOS)
3. All the player settings are correctly modified in order to build to device

# animation
 I worked a total of the animation (KEY,COIN). To make the game better
Possible use by animator 
open the animator  And arrange them as you like
# Motivation

 create my  first fully interactive multisensory VR experience!

# Installation
use the script and put in unity drag and drop
``
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mobile : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       // transform.Rotate(0, Input.acceleration.y * 10f * Time.deltaTime, 0);
        //Input.acceleration.x * Time.deltaTime * 10f
      //  transform.Rotate(Input.acceleration.x * Time.deltaTime * 10f, 0, 0);


        //Input.acceleration.y * 10f * Time.deltaTime

       transform.Rotate(0, 0, Input.acceleration.y * 10f * Time.deltaTime);
	}
}

``
Google VR SDK for Unity
===========================================================
Enables Daydream and Cardboard app development in Unity.

Copyright (c) 2016 Google Inc. All rights reserved.

For updates, known issues, and upgrade instructions, see: https://developers.google.com/vr/unity/release-notes

For first time users, see the Get Started Guides for [ Android Cardboard](https://developers.google.com/vr/unity/get-started),  [  Android Daydream](https://developers.google.com/vr/unity/get-started), and  [ iOS Cardboard](https://developers.google.com/vr/unity/get-started-ios).

# API Script FOR UNITY

[ API SCRIPT](https://docs.unity3d.com/ScriptReference/index.html)

# Contributors
[Mohamed Galal](abogalalmedo@gmail.com) gmail

[Mohamed Galal Anwer](https://www.linkedin.com/in/mohamedgalalanwer/) linkedin






 
   if u'd see 
  https://www.youtube.com/watch?v=KKidJKfgoo0
