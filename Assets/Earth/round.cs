using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class round : MonoBehaviour {

    private GameObject moon;
    private GameObject earth;

	// Use this for initialization
	void Start () {
        earth = GameObject.Find("Earth");
        moon = GameObject.Find("Moon");
        
	}
	
	// Update is called once per frame
	void Update () {
        moon.transform.RotateAround(earth.transform.position, Vector3.up, 0.06f);
        transform.Rotate(0, 20 * Time.deltaTime, 0);
    }
}
