using UnityEngine;

public class PlayerScrimpt : MonoBehaviour {

    Rigidbody rb;
    bool ninjaStarPhase;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        ninjaStarPhase = false;
    }

    // Update is called once per frame
    void FixedUpdate () {
        if (Input.GetKeyDown("d"))
        {
            rb.AddForce(0, 0, 250);
        }

        if (Input.GetKeyDown("a"))
        {
            rb.AddForce(0, 0, -250);
        }

    }

}
