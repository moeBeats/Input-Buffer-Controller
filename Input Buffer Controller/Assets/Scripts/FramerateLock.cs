using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FramerateLock : MonoBehaviour
{
    [SerializeField] int FrameRate = 60;
    void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = FrameRate;
    }
}
