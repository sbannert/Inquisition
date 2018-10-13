﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformHeadScript : MonoBehaviour {

    [SerializeField]
    Transform player;
    [SerializeField]
    float shrinkInterval;
    bool hasShrunk;

    private void Start()
    {
        hasShrunk = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.name == "Player") && (collision.transform.position.y > transform.position.y) && (hasShrunk))
        {
            hasShrunk = false;
            StartCoroutine(DelayTime());
            
        }
    }

    private IEnumerator DelayTime()
    {
        for (int i = 0; i < 200; i++)
        {
            yield return new WaitForSeconds(shrinkInterval);
            transform.localScale -= new Vector3(0, 0.01f, 0);
            transform.localPosition -= new Vector3(0, 0.01f, 0);
        }
    }


}
