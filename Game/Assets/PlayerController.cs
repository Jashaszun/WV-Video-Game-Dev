using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	const float VELOCITY = 15;

	// Use this for initialization
	void Start()
	{
		
	}
	
	// Update is called once per frame
	void Update()
	{
		float velX = 0, velY = 0;
		if (Input.GetKey(KeyCode.LeftArrow))
			velX--;
		if (Input.GetKey(KeyCode.RightArrow))
			velX++;
		if (Input.GetKey(KeyCode.UpArrow))
			velY++;
		if (Input.GetKey(KeyCode.DownArrow))
			velY--;

		Vector3 vel = new Vector3(velX, velY);
		vel = vel.normalized * VELOCITY;

		transform.position += vel * Time.deltaTime;
	}
}
