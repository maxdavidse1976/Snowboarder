using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _torqueAmount = 1f;
    CircleCollider2D _headCollider;
    Rigidbody2D _rigidbody;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _headCollider = GetComponent<CircleCollider2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rigidbody.AddTorque(_torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            _rigidbody.AddTorque(-_torqueAmount);
        }
    }
}
