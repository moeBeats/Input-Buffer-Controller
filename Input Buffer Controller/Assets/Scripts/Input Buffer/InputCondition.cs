using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Buffer/Condition")]
public class InputCondition: ScriptableObject
{
    public bool GroundOkay = true;
    public bool AirOkay;
    public int MeterCost = 0;

}
