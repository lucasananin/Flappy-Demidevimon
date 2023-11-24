using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb = null;
    [SerializeField] float _jumpForceMultiplier = 10f;

    private void Start()
    {
        _rb.simulated = false;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }

    private void LateUpdate()
    {
        _rb.simulated = GameManager.Instance.IsPlaying();
    }

    private void Jump()
    {
        _rb.velocity = Vector2.up * _jumpForceMultiplier;
        AudioManager.Instance.PlayFlapSfx();
    }
}
