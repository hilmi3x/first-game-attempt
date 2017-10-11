
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public float forwardForce = 3000f;
	public float sideForce = 80f;
	public float speedupForce = 250f;
	
	// Update is called once per frame
	void FixedUpdate () {
		rb.AddForce(0,0,forwardForce * Time.deltaTime);

		if (forwardForce < 4000f) {
			if (Input.GetKey ("w")) {
				forwardForce = forwardForce + speedupForce;
				rb.AddForce (0, 0, forwardForce * Time.deltaTime);
			}
		}

		if (forwardForce > 2000f) {
			if (Input.GetKey ("s")) {
				forwardForce = forwardForce - speedupForce;
				rb.AddForce (0, 0, forwardForce * Time.deltaTime);
			}
		}

		if (Input.GetKey ("d")) {
			rb.AddForce (sideForce  * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey ("a")) {
			rb.AddForce (-sideForce  * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
	}
}
