using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterControllerScript : MonoBehaviour
{
   


    public bool jump;
    private Vector3 initialPosition;
    private Vector3 initialRotation;
    private float horizontalValue;
    private float verticalValue;
    private GameObject characterGameObject;


    //Character Stats
    float moveSpeed = .05f;

    private CharacterController charCont;
    // Start is called before the first frame update
    void Start()
    {

        characterGameObject = gameObject;
        initialPosition = GetComponent<Transform>().position;
        initialRotation = GetComponent<Transform>().rotation.eulerAngles;
        charCont = GetComponent<CharacterController>();
    
    }
    
    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector3 motion = new Vector3(horizontalValue, -2, verticalValue);
        Vector3 rotation = new Vector3(horizontalValue, 0, verticalValue);
                 
        if (rotation.magnitude > 0.1f)
        {
            float targetAngle = Mathf.Atan2(motion.x, motion.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);
            
        }
        //Actual Character Movement
        charCont.Move(motion * moveSpeed);


    }

    public void givenInputs(playerInputStruct inputs)
    {
        horizontalValue = inputs.horizontalInput;
        verticalValue = inputs.verticalInput;
    }

    public void resetInputs()
    {
        horizontalValue =0;
        verticalValue = 0;
    }





    public void reset()
    {
        resetInputs();
        charCont.enabled = false;
        charCont.transform.position = initialPosition;
        charCont.transform.eulerAngles = initialRotation;
        charCont.enabled = true;
        
    }
}
