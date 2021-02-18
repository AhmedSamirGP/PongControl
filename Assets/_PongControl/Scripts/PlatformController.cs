using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    private Rigidbody2D _rb2d;
    [SerializeField] float _speed = 5f;


    [SerializeField] KeyCode _keyUp;
    [SerializeField] KeyCode _keyDown;

    // Start is called before the first frame update
    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _rb2d.velocity = Vector2.zero;

        if (Input.GetKey(_keyUp))
        {
            _rb2d.velocity += new Vector2(0.0f, _speed);
        }
        if (Input.GetKey(_keyDown))
        {
            _rb2d.velocity -= new Vector2(0.0f, _speed);
        }
    }
}
