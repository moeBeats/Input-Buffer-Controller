using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Statistic Sheet", menuName = "Player Statistics/Sheet")]
public class StatSheet : ScriptableObject
{
    public AttackStat Light, Medium, Heavy;

}
