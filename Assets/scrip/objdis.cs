using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objdis : MonoBehaviour {
	public GameObject destroyerpoint;

	// Use this for initialization
	void Start () {
		destroyerpoint = GameObject.Find ("despoint");
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < destroyerpoint.transform.position.x) {
			Destroy (gameObject);
		}

	}
}
