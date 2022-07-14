using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float x { get; private set; }
    public float y { get; private set; }

    // Update is called once per frame
    void Update()
    {
        x = y = 0f;

        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
    }
}
