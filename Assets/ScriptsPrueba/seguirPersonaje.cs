﻿using UnityEngine;
using System.Collections;

public class seguirPersonaje : MonoBehaviour {

	public Transform personaje;
	public float separacion = 3f;
	public float altura = 3f;
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (personaje.position.x+separacion, transform.position.y, transform.position.z);
	}
}
