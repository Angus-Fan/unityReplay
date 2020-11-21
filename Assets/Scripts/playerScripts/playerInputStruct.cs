using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct playerInputStruct
{

    public float verticalInput;
    public float horizontalInput;


    public playerInputStruct(float horizontalValue, float verticalValue)
    {
        verticalInput = verticalValue;
        horizontalInput = horizontalValue;

    }

}
