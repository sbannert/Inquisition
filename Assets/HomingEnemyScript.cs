using System.Collections;
using UnityEngine;

public class HomingEnemyScript : MonoBehaviour {
    [SerializeField]
    Transform player;
    [SerializeField]
    float step;
    Transform temporary;
    float playerX;
    float playerY;
    float playerZ;

    IEnumerator DelayTime()
    {
        yield return new WaitForSeconds(0);
        playerX = player.position.x;
        playerY = player.position.y;
        playerZ = player.position.z;
        temporary.transform.position = new Vector3(playerX, playerY, playerZ);
    }

    // Use this for initialization
    void Start () {
        StartCoroutine(DelayTime());
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, temporary.position, 3);
	}
}
