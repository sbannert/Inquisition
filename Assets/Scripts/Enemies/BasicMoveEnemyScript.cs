using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasicMoveEnemyScript : MonoBehaviour {

    private Rigidbody rb;
    [SerializeField]
    float speed;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        speed = -2;
    }

    void FixedUpdate()
    {
        Vector3 vect = new Vector3(speed, 0, 0);
        rb.MovePosition(transform.position + vect * Time.deltaTime);
    }

    // Update is called once per frame
    void Update () {
        //RaycastHit hit;
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (collision.gameObject.name == "Floor10")
        {
            speed = 2;
        }
    }
}
