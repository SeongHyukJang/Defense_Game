using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

    //This script is for controlling the character gameobject movements.

    public float speed = 10F;




	// Use this for initialization
	void Start () {

        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {

        float translation = Input.GetAxis("Vertical") * speed;
        float straffe= Input.GetAxis("Horizontal") * speed;
        float translation1 = Input.GetAxis("Jump") * speed;

        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;
        translation1 *= Time.deltaTime;

        transform.Translate(straffe, translation1, translation);

        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;



    }
}
