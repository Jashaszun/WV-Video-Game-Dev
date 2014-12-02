using UnityEngine;
using System.Collections;

public class TurretController : MonoBehaviour
{
	GameObject player;

	const float BULLET_INTERVAL = .75f;
	float bulletElapsed = 0;

	void Start()
	{
		player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update()
	{
		RaycastHit raycast;
		bool seesPlayer = Physics.Raycast(new Ray(transform.position, player.transform.position - transform.position), out raycast);
		if (raycast.transform != player.transform)
			seesPlayer = false;
			
		if (seesPlayer)
		{
			float angle = Mathf.Atan2(
				player.transform.position.y - transform.position.y,
				player.transform.position.x - transform.position.x);
			transform.rotation = Quaternion.AngleAxis(angle * 180 / Mathf.PI - 90, new Vector3(0, 0, 1));

			bulletElapsed += Time.deltaTime;
			if (bulletElapsed >= BULLET_INTERVAL)
			{
				bulletElapsed = 0;
				GameObject bullet = (GameObject)Instantiate(GameObject.Find("Bullet"));
				bullet.transform.position = this.transform.position;
				bullet.rigidbody.velocity = new Vector3(BulletController.SPEED * Mathf.Cos(angle), BulletController.SPEED * Mathf.Sin(angle), 0);
			}
		}
		else
			bulletElapsed = 0;
	}
}
