using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Statistic Sheet", menuName = "Player Statistics/Attack")]
public class AttackStat : ScriptableObject
{
    public Animation Attack;

    public int ComboLevel;
}
