using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buffer : MonoBehaviour
{
    [SerializeField] BufferInput[] _buffer;
    [SerializeField] int _bufferSize;
    void Awake()
    {
        _buffer = new BufferInput[_bufferSize];
    }
    void Add()
    {
        _buffer[0] = null;
    }
}
