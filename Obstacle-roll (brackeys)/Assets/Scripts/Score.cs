using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public Transform player;
	public Text scoreText;

    void Update()
    {
		scoreText.text = player.position.z.ToString("0");
		//.text allows you to change the text itself
		//.z --> how many units moved on the z axis
		//.ToString() makes a number a string
		//"0" --> makes it whole numbers
    }
}
