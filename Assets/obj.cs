using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj : MonoBehaviour {
	public GameObject the;
	public Transform point;
	public float distance;
	public float dismin;
	public float dismax;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x < point.position.x)
		{
			distance = Random.Range (dismin, dismax);
			transform.position = new Vector3 (transform.position.x + distance, transform.position.y, transform.position.z);
			Instantiate (the, transform.position, transform.rotation);
	}
}
}
