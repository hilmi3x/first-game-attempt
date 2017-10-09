
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public float forwardForce = 200f;
	public float sideForce = 500f;
	public float speedupForce = 5f;
	
	// Update is called once per frame
	void FixedUpdate () {
		rb.AddForce(0,0,forwardForce * Time.deltaTime);

		if (forwardForce < 500f) {
			if (Input.GetKey ("w")) {
				forwardForce = forwardForce + speedupForce;
				rb.AddForce (0, 0, forwardForce * Time.deltaTime);
			}
		}

		if (forwardForce > 100f) {
			if (Input.GetKey ("s")) {
				forwardForce = forwardForce - speedupForce;
				rb.AddForce (0, 0, forwardForce * Time.deltaTime);
			}
		}

		if (Input.GetKey ("d")) {
			rb.AddForce (sideForce  * Time.deltaTime, 0, 0);
		}

		if (Input.GetKey ("a")) {
			rb.AddForce (-sideForce  * Time.deltaTime, 0, 0);
		}
	}
}
