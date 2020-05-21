using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	public PlayerMovement movement;
	
	void OnCollisionEnter(Collision collisionInfo) //The "Collision" between the brackets lets unity know we want to gather info about the collision
	{
		if (collisionInfo.collider.tag == "Obstacle")
		//.collider --> info about the collider we hit
		//.tag --> collider tag
		{
			movement.enabled = false; // movement could be replaced by GetComponent<PlayerMovement>()
			FindObjectOfType<GameManager>().EndGame(); //similar to GetComponent, the . after allows you to access whatever is in that object
		}
	}
}
