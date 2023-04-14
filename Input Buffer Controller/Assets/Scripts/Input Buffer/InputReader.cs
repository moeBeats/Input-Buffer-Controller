using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour
{
    Buffer _buffer;
    Player _player;
    private void Awake()
    {
        _buffer = GetComponent<Buffer>();
        _player = GetComponent<Player>();
    }
    public void OnHorizontal(InputAction.CallbackContext context)
    {
        float horizontal = context.ReadValue<float>();
        _buffer.Direction.x = horizontal;
    }
    public  void OnVertical(InputAction.CallbackContext context)
    {
        float vertical = context.ReadValue<float>();
        _buffer.Direction.y = vertical;
    }
    public void OnLight(InputAction.CallbackContext context)
    {
        _buffer.Add(_buffer.Collection.A);
        Debug.Log("test");
    }
    public void OnMedium(InputAction.CallbackContext context)
    {
        _buffer.Add(_buffer.Collection.B);
    }
    public void OnHeavy(InputAction.CallbackContext context)
    {
        _buffer.Add(_buffer.Collection.C);
    }
}
