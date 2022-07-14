using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput _input;
    Rigidbody _rigidbody;
    public float speed = 1f;
    public bool UseSpeed = false;

    // Start is called before the first frame update
    void Start()
    {
        _input = GetComponent<PlayerInput>();
        _rigidbody = GetComponent<Rigidbody>();

        Debug.Log("PlayerMovement Start");
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = _input.x * speed;
        float ySpeed = _input.y * speed;

        if (UseSpeed)
        {
            _rigidbody.velocity = new Vector3(xSpeed, 0f, ySpeed);
        }
        else
        {
            _rigidbody.AddForce(xSpeed, 0f, ySpeed);
        }
    }
}
