using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    Rigidbody _rb;
    [SerializeField] float _moveSpeed = 5.0f;
    float _h;
    float _v;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _h = Input.GetAxisRaw("Horizontal");
        _v = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        Vector3 dir = Vector3.forward * _v + Vector3.right * _h;
        dir.y = 0;
        if (dir != Vector3.zero) this.transform.forward = dir;
        float y = _rb.velocity.y;

        _rb.velocity = dir * _moveSpeed + Vector3.up * y;
    }
}
