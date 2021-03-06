﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SmartMoveEnemyScript : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    float speed;
    [SerializeField]
    float left;
    [SerializeField]
    float right;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //speed = 2;
    }

    private void FixedUpdate()
    {
        Vector3 vect = new Vector3(speed, 0, 0);
        rb.MovePosition(transform.position + vect * Time.deltaTime);
        /*if (rb.position.x < 19) {
            speed = -2;
        }*/
        /*if (rb.position.x > 13)
        {
            speed = 2;
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.position.x > right)
        {
            speed = speed * -1;
        }
        if (rb.position.x < left)
        {
            speed = speed * -1;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
