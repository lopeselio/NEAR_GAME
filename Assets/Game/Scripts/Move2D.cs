using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move2D : MonoBehaviour
{
    public float m_speed = 1.0f;
    private Rigidbody2D _rigidbody2D;
    private Animator _animator;
    private Vector2 _userinput;

    void Awake() {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    public void Move(InputAction.CallbackContext context){
        _userinput = context.ReadValue<Vector2>();
        _animator.SetFloat("speed", _userinput.magnitude);
    }

    void FixedUpdate () {
        _rigidbody2D.MovePosition(_rigidbody2D.position + _userinput * Time.fixedDeltaTime * m_speed);
    }
}
