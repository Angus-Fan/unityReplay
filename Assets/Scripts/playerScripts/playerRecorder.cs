using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRecorder : MonoBehaviour
{
   
    //This class should include all the potential inpuits that the player makes
    //These two are the movement inputs in both horizontal and vertical movement
    private float horizontalValue;    
    private float verticalValue;
    
 
    // Start is called before the first frame update
    void Start()
    {
        
    }  

    private void Update()
    {

        horizontalValue = Input.GetAxis("Horizontal");
        verticalValue = Input.GetAxis("Vertical");
       
       
    }

    public playerInputStruct getInputStruct()
    {
        playerInputStruct playerInputs = new playerInputStruct(horizontalValue, verticalValue);
        return playerInputs;
    }

    public void resetInput()
    {
        horizontalValue = 0;
        verticalValue = 0;
    }


}
   

