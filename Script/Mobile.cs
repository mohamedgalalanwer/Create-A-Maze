using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mobile : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       // transform.Rotate(0, Input.acceleration.y * 10f * Time.deltaTime, 0);
        //Input.acceleration.x * Time.deltaTime * 10f
      //  transform.Rotate(Input.acceleration.x * Time.deltaTime * 10f, 0, 0);


        //Input.acceleration.y * 10f * Time.deltaTime

       transform.Rotate(0, 0, Input.acceleration.y * 10f * Time.deltaTime);
	}
}
