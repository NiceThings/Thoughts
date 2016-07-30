using UnityEngine;
using System.Collections;

public class RotationScript : MonoBehaviour {

	public float speed = 300.0f;	
	private float time = 0.0f;
	// Update is called once per frame
	void Update () {	
		// Quaternion q = Quaternion.AngleAxis(Time.deltaTime * 10f, Vector3.up);

		// Quaternion e = Quaternion.Euler(0,30,0);

		// transform.rotation = Quaternion.Lerp(transform.rotation, e, Time.deltaTime);

		time = Time.time;
		Quaternion circleAroundZAxis = Quaternion.AngleAxis(10 * time, Vector3.up);

		Debug.Log("Time:" + time);
		Debug.Log("Current Rotation: " + transform.rotation);
		Debug.Log("New Rotation: " + circleAroundZAxis);
		Debug.Log("Identity: " + Quaternion.identity);
		transform.rotation = Quaternion.Lerp(transform.rotation, circleAroundZAxis, speed);
	}
	
}
