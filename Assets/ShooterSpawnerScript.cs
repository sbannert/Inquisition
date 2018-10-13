using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterSpawnerScript : MonoBehaviour {

    [SerializeField]
    GameObject homing;
    Vector3 vectLocation;
    bool notMadeShooter;

    private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag == "Player") && notMadeShooter)
        {
            GameObject homingObj = (GameObject)Instantiate(homing, vectLocation, transform.rotation);
            //spikeObj.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            homingObj.transform.parent = transform;
            notMadeShooter = false;
        }
    }

    void Start()
    {
        vectLocation = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        //StartCoroutine(DelayTime());
        notMadeShooter = true;
    }

    /*private IEnumerator DelayTime()
    {
        yield return new WaitForSeconds(0);
        GameObject homingObj = (GameObject)Instantiate(homing, vectLocation, transform.rotation);
        //spikeObj.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        homingObj.transform.parent = transform;
        Start();
    }*/

}
