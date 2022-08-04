using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
public class MoveController : MonoBehaviour
{
    [Header("Rigibody:")]
    [SerializeField] public Rigidbody _rigidbody;
    [Header("UI elements:")]
    [SerializeField] public FixedJoystick _joystick;
    [Header("Animations:")]
    [SerializeField] private AnimationController _animator;


    [SerializeField] private float _moveSpeed;

    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, _rigidbody.velocity.y, _joystick.Vertical * _moveSpeed);

        if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
            _animator.SetRunTrigger();
        }    
        else
        {
            _animator.SetIdletrigger();
        }
    }
}
