using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BufferInstance
{
    public BufferInput BufferInput;
    public bool HasBeenUsed = false;

    public BufferInstance()
    {
        //BufferInput.Input = input;
    }
}
