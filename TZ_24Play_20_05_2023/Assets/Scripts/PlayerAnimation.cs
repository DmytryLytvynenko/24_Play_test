using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;
    private bool isGrounded = false;

    private void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        _animator.SetBool("Idle", isGrounded);
    }

    void OnCollisionEnter(Collision collision)
    {
        IsGroundedUpate(collision, true);
    }
    void OnCollisionExit(Collision collision)
    {
        IsGroundedUpate(collision, false);
    }
    private void IsGroundedUpate(Collision collision, bool value)
    {
            isGrounded = value;
    }
}
