using UnityEngine;
using System.Collections;

public class TurretController : MonoBehaviour
{
	GameObject player;

	// Use this for initialization
	void Start()
	{
		player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update()
	{
		Vector2 delta = new Vector2(player.transform.position.x - transform.position.x,
		                            player.transform.position.y - transform.position.y);
		Debug.Log("Angle: " + Mathf.Atan2(
			player.transform.position.y - transform.position.y,
			player.transform.position.x - transform.position.x));
		transform.rotation = Quaternion.AngleAxis(
			Mathf.Atan2(
				player.transform.position.y - transform.position.y,
				player.transform.position.x - transform.position.x) * 180 / Mathf.PI - 90,
			new Vector3(0, 0, 1));
	}
}
