using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    [SerializeField]
    float speed = 10f;
    float go = 1f;
    // Update is called once per frame
    void Update ()
    {
            go = Time.deltaTime * speed;
    }

    public void Run(float moveX)
    {
        Vector3 movingVector = new Vector3(moveX, 0.0f, 0.0f);
        movingVector *= go;
        transform.Translate(movingVector, Space.World);
    }
}
