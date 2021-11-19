# Unity Input Recorder & Replayer
Unity project which is used in the replay video. This system listens for key inputs, records the inputs along with the timestamp where they are pressed. 

![demo](https://user-images.githubusercontent.com/33101170/142538241-a26be52d-3661-40a8-b33a-f4d06bb5b0ba.gif)

# Installation & Setup
- Download the project files, unzip them, and open it with Unity.
- Locate the demo scene found at Assets/Scenes/demoScene and open the scene.

# Usage 🎥
- Enter play mode, and then select the mode of the character.
- Hit **RECORD** to enter recording mode, move around with WASD and when finished hit either reset or the play button.
- The **RESET** key resets the player and the time to the origin point (this does **NOT** reset the recorded inputs).
- Hit **PLAY** to replay the recorded actions
- If you would like to overwrite your previous actions simply hit the **RECORD** button again.

# Modifications 🛠️

This section will cover adding additional functionality for your own projects.

## Adding New Inputs

If you want to add new inputs you must do the following. 
1. Update the **playerRecorder**
2. Update the **playerInputStruct**
3. Update the **characterControllerScript**

## Player Recorder
If you want to add new key inputs add them to the **listenForKeyPresses()** function. Do keep in mind that this project uses the Old Unity Input system, you will need to update the code that listens for inputs if you are using the new system.
![playerRecorder](https://user-images.githubusercontent.com/33101170/142534862-93e1d889-7dc6-4cbd-acd1-dd0b23e83ee6.PNG)

I have noticed that some inputs are skipped when listening for inputs in FixedUpdate, my workaround was to listen for inputs in the Update() loop and then set them when the FixedUpdate() executes. If you can find a workaround please mark it under issues, and I will update the repository. 

## Player Input Struct

When you have added your new button to the Player Recorder, you must then update the playerInputStruct. This holds the recorded values, so if you need your new inputs to be recorded add a new variable here and modify the playerInputStruct constructor.

![playerInputStruct](https://user-images.githubusercontent.com/33101170/142534839-1c6482b0-1675-4662-bd51-a7ef159bbd02.PNG)

## Character Controller Script

When both are updated, you can then make the character controller react to the key input. In this case if our buttonPressed value is true our characterControllerScript will execute the print statement. Instead of the print statement you can add whatever functionality you would like your character to do.

![characterController](https://user-images.githubusercontent.com/33101170/142534765-38d60556-eddb-4d28-ad92-43eaecfcf6e9.PNG)
