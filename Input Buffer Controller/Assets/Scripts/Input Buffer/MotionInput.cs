using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Buffer/Motion")]
public class MotionInput : ScriptableObject
{
    public BufferInput[] Inputs;
    public int Priority;
    public int Window;
    public InputCondition Condition;
}
