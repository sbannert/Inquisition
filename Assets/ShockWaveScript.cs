using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShockWaveScript : MonoBehaviour {

    [SerializeField]
    float speed;
	
	// Update is called once per frame
	void Update () {
        Vector3 vect = new Vector3(1, 0, 0);
        transform.Translate(Vector3.left * Time.deltaTime * speed);
	}

    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
