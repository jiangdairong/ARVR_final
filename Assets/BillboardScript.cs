﻿using UnityEngine;
using System.Collections;

public class BillboardScript : MonoBehaviour {
	public Camera my_camera;


	// Update is called once per frame
	void Update () 
	{
		transform.LookAt (transform.position + my_camera.transform.rotation*Vector3.back,
			my_camera.transform.rotation*Vector3.down);
	}
}
