using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class actorObject : MonoBehaviour
{
    //What do actor objects need?
    //List-----------------------
    //1. Player Input
    //   Need a player recorder class to record inputs that are being sent to character.
    //2. Object Controller
    //   This object controller needs to read inputs and apply them to object.
    //3. Recording System / Playback System
    //   Recording system will need to record inputs from the player and then be able to play it back to the object


    //1 
    private playerRecorder playerInput;

    //2
    private characterControllerScript objectController;

    //3
    private inputRecorder inputRec;

    public enum state
    {
        Playing,
        Playback,
        Reset

    }
    public state currentState;


    //Booleans to check initial state changes
    private bool newPlayback = false;
    private float timer;
    private float playbackTimer;

    //UI Timer
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        //initialize the variables
        playerInput = GetComponent<playerRecorder>();
        objectController = GetComponent<characterControllerScript>();
        inputRec = GetComponent<inputRecorder>();
        //Player starts as idle until their clicked on, prob change this later
        currentState = state.Reset;
        timer = 0;
        playbackTimer = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if ((int)currentState == 0)
        {
            
            timer = timer + Time.deltaTime;
            timerText.text = timer.ToString("F2");
            playerInput.getInputs();
            playerInputStruct userInput = playerInput.getInputStruct();
            inputRec.addToDictionary(timer, userInput);            
            objectController.givenInputs(userInput);
            objectController.move();
            playerInput.resetInput();
        }

        if ((int)currentState == 1)
        {
            if (newPlayback == true)
            {              
                playbackTimer = 0;
                newPlayback = false;
            }
            
            playbackTimer = playbackTimer + Time.deltaTime;
            timerText.text = playbackTimer.ToString("F2");
            if (inputRec.keyExists(playbackTimer))
            {
                playerInputStruct recordedInputs = inputRec.getRecordedInputs(playbackTimer);
                objectController.givenInputs(recordedInputs);
                objectController.move();
            }

        }

        if ((int)currentState == 2)
        {
            timer = 0;
            timerText.text = "0.00";
            
           
            
        }
    }

    public void recording()
    {
        timer = 0;
        inputRec.clearHistory();
        currentState = state.Playing;
    }


    public void playback()
    {
        newPlayback = true;
        currentState = state.Playback;
    }

    public void reset()
    {
        objectController.reset();
        currentState = state.Reset;
        playerInput.resetInput();
    }
}
