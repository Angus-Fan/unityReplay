using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{

   
    public GameObject selectedPlayer;
    

    public void startRecording()
    {
        resetPlayer();
        selectedPlayer.GetComponent<actorObject>().recording();
    }

    public void startPlayback()
    {
        resetPlayer();
        selectedPlayer.GetComponent<actorObject>().playback();
    }

    public void resetPlayer()
    {
        selectedPlayer.GetComponent<actorObject>().reset();

    }


        
 }

