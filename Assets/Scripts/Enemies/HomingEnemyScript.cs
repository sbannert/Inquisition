using System.Collections;
using UnityEngine;

public class HomingEnemyScript : MonoBehaviour {
    [SerializeField]
    GameObject player;
    [SerializeField]
    float step;
    [SerializeField]
    float moveDelay;
    Transform tempPlayer;


    // Use this for initialization
    void Awake () {
        GameObject tempPlayer = new GameObject("player");
        tempPlayer.transform.position = player.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        StartCoroutine(DelayTime());
    }

    private IEnumerator DelayTime()
    {
        yield return new WaitForSeconds(moveDelay);
        Vector3.MoveTowards(transform.position, tempPlayer.transform.position, step);  //This is the movement to be changed
    }

}
