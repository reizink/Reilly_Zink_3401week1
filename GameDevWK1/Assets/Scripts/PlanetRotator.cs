using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotator : MonoBehaviour 
{
    public Vector3 speed;
	
	// Update is called once per frame
	void Update () 
    {
        //Debug.Log(Random.Range(1,10));

        //transform.rotation.y
        //float: transform.Rotate(0, speed, 0); //Vector3.up, 1 or => new Vector3 (0,1,0) => 0,1,0
        transform.Rotate(speed);
    }
}
