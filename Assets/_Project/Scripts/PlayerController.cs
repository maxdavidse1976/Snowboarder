using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _torqueAmount = 1f;
    [SerializeField] float _boostSpeed = 30f;
    [SerializeField] float _baseSpeed = 20f;

    CircleCollider2D _headCollider;
    Rigidbody2D _rigidbody;
    SurfaceEffector2D _surfaceEffector2D;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _headCollider = GetComponent<CircleCollider2D>();
        _surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        RotatePlayer();
        RespondToBoost();
    }

    void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            _surfaceEffector2D.speed = _boostSpeed;
        }
        else
        {
            _surfaceEffector2D.speed = _baseSpeed;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            _rigidbody.AddTorque(_torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            _rigidbody.AddTorque(-_torqueAmount);
        }
    }
}
