using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour {

    public GameObject myCube;
    public Vector3 movementVector;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (myCube.transform.position.x<13)
        {
            myCube.transform.position += movementVector;
        }

    }
}
