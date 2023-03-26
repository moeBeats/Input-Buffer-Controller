using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BufferInput : MonoBehaviour
{
    public GameInput Input;
    public int TimeHeld = 0;
    public bool HasBeenUsed = false;

    public BufferInput(GameInput gameInput)
    {
        Input = gameInput;
    }
}
