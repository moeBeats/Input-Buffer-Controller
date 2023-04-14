using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buffer : MonoBehaviour
{
    [SerializeField] BufferInstance[] _buffer;
    [SerializeField] int _bufferSize;
    public InputCollection Collection;
    public Vector2 Direction;
    [SerializeField] int _currentTick = 0;

    void Awake()
    {
        _buffer = new BufferInstance[_bufferSize];
    }
    private void FixedUpdate()
    {
        _buffer[0].BufferInput.TimeHeld++;
        Debug.Log(_currentTick);
        //RaiseBuffer();
    }
    public void Add(GameInput input)
    {
        //_buffer[]
        _buffer[0].BufferInput.Input = input;
        _buffer[_buffer.Length - 1].BufferInput.Input = null;
    }

    public void RaiseBuffer()
    {
        for (int i = 0; i < _buffer.Length - 1; i++)
        {
            if (_buffer[i + 1] != null && _currentTick < _bufferSize)
            {
                _currentTick++;
                _buffer[i + 1] = _buffer[i];
            }
            else
            {
                _currentTick = 0;

            }
        }
    }
}
