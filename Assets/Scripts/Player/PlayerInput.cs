using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {
    Move moveComponent;
    //Jump jumpComponent;
	// Use this for initialization
	void Start ()
    {
        moveComponent = this.GetComponent<Move>();
        //jumpComponent = this.GetComponent<Jump>();
        if(moveComponent == null)
        {
            Debug.LogError("No Move instance found attatched to this game object.");
        }
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        float moveX = Input.GetAxis("MovementX");
        //float moveY = Input.GetButton("Jump");

        moveComponent.Run(moveX);
        //jumpComponent.Start(moveY);

	}
}
