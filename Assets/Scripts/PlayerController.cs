using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    Rigidbody _rb;
    [SerializeField] float _moveSpeed = 5.0f;
    [SerializeField] string _merchantTag;
    [SerializeField] GameObject _shopPanel;
    float _h;
    float _v;
    bool _shopping = false;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _h = Input.GetAxisRaw("Horizontal");
        _v = Input.GetAxisRaw("Vertical");
        
        if (_shopping && Input.GetKeyDown(KeyCode.E))
        {
            _shopPanel.SetActive(true);
        }
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
        dir = dir.normalized * _moveSpeed;
        float y = _rb.velocity.y;

        _rb.velocity = dir * _moveSpeed + Vector3.up * y;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(_merchantTag))
        {
            _shopping = true;
        }
    }
}
