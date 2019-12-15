using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {

	public Vector2 jumpForce = new Vector2(10, 1000);

	// Update is called once per frame
	void Update ()
	{
		// Jump
		if (Input.GetKeyDown("space"))
		{
			GetComponent<Rigidbody>().velocity = Vector2.zero;
			GetComponent<Rigidbody>().AddForce(jumpForce);
		}
		// Die by being off screen
		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0)
		{
			Die();
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "death") {
			print (" i am death");
			Application.LoadLevel (0);
		}
	}

	// Die by collision
	void OnCollisionEnter2D(Collision2D other)
	{
		Die();
	}

	void Die()
	{
	Application.LoadLevel(Application.loadedLevel);
	}
}


	


