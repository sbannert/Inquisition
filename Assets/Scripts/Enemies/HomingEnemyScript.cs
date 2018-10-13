using System.Collections;
using UnityEngine;

public class HomingEnemyScript : MonoBehaviour {
    [SerializeField]
    GameObject player;
    [SerializeField]
    float speed;
    [SerializeField]
    float moveDelay;
    float playerX;
    float playerY;
    float playerZ;
    Vector3 toLocation;


    // Use this for initialization
    void Awake () {
        playerX = player.transform.position.x;
        playerY = player.transform.position.y;
        playerZ = player.transform.position.z;
        toLocation = new Vector3(playerX, playerY, playerZ);
        Debug.Log(toLocation);
        StartCoroutine(DelayTime());

    }
	
	// Update is called once per frame
	void Update () {
        //StartCoroutine(DelayTime());
    }

    private IEnumerator DelayTime()
    {
        yield return new WaitForSeconds(moveDelay);
        for (int i = 0; i < 1000; i++)
        {
            transform.localPosition = Vector3.MoveTowards(transform.position, toLocation, Time.deltaTime * speed);  //This is the movement to be changed
        }
    }

}
