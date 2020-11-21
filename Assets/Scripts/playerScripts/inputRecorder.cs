using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputRecorder : MonoBehaviour
{
    private playerRecorder playerInputs;
    private Dictionary<float,playerInputStruct> playerInputRecord;
      
    void Start()
    {
        //Intialize the queue that will be used to record inputs
        playerInputRecord = new Dictionary<float, playerInputStruct>();
       
    }   
    //Adds the timeStamp and playerInputs into the dictionary
    //The timeStamp is the key
    //The inputStruct (inputs) is the value of the key
    //This function is used by the actorObject script as the dictionary is private
    public void addToDictionary(float time,playerInputStruct inputs)
    {
        playerInputRecord.Add(time, inputs);
    }


    public void clearHistory()
    {
        playerInputRecord = new Dictionary<float, playerInputStruct>();
    }
    
    //Check if key exists
    public bool keyExists(float key)
    {
        return playerInputRecord.ContainsKey(key);
    }
    //Returns the inputStruct at current timeStamp(in)
    public playerInputStruct getRecordedInputs(float timeStamp)
    {
        return playerInputRecord[timeStamp];
    }
}
