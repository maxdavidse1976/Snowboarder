using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D _rigidbody;
    [SerializeField] float _torqueAmount = 1f;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
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
