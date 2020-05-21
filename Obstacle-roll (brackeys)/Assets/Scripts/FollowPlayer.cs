using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
	public Transform player;
	public Vector3 offset;

    void Update()
    {
        transform.position = player.position + offset;
		//transform with a lowercase t refers to the transform of the gameobject the script is on
    }
}
