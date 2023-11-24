using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] Animator _animator = null;
    [SerializeField] Rigidbody2D _rb = null;

    private static int _yVelocityHash = Animator.StringToHash("yVelocity");
    private static int _takeDamageHash = Animator.StringToHash("takeDamage");

    private void LateUpdate()
    {
        _animator.SetFloat(_yVelocityHash, _rb.velocity.y);
    }

    public void TriggerTakeDamage()
    {
        _animator.SetTrigger(_takeDamageHash);
    }
}
