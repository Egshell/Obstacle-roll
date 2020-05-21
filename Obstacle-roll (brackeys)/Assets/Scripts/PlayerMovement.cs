using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public Rigidbody rb; // public/private, component, name

	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;

    void FixedUpdate()
	{
        rb.AddForce(0, 0, forwardForce *  Time.deltaTime); // Time.deltaTime --> the higher the frame rate, the lower the value
		
		if( Input.GetKey("d") )
		{
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //ForceMode --> specify the type of force you want, VelocityChange --> directly edits its velocity and ignores mass
		}
				
		if( Input.GetKey("a") )
		{
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if(rb.position.y < -1f)
		{
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}