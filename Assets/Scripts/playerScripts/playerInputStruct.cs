using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct playerInputStruct
{

    public float verticalInput;
    public float horizontalInput;

    public bool buttonPressed;

    public playerInputStruct(float horizontalValue, float verticalValue, bool buttonvalue)
    {
        verticalInput = verticalValue;
        horizontalInput = horizontalValue;
        buttonPressed = buttonvalue;

    }

}
