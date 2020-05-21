using UnityEngine;

public class EndTrigger : MonoBehaviour
{
	public GameManager gameManager;

	void OnTriggerEnter() // OnCollisionEnter does not work if the object is marked trigger
	{
		gameManager.CompleteLevel();
	}
}
