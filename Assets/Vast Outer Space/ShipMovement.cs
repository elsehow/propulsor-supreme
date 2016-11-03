using UnityEngine;
using System.Collections;

public class ShipMovement : MonoBehaviour {

	public float speed;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		speed = 1000.0f;
	}

	void FixedUpdate ()
	{
		float forceNorthSouth = Input.GetAxis ("NorthSouth");
		float forceEastWest = Input.GetAxis ("EastWest");
		float forceUpDown = Input.GetAxis ("UpDown");

		Vector3 movement = new Vector3 (forceEastWest, forceUpDown, forceNorthSouth);

		rb.AddForce(movement * speed);
	}
}