using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 10f; // Speed of the movement
    private Rigidbody2D myRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () {
// moving the object on x, you can choose direction (x,y,z) change to vector2 if its 2D (x,y)
        Debug.Log(Input.GetAxisRaw("Horizontal"));
		myRigidbody.velocity =  new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed; 
	}
} //making random change here to just see how github desktop works
