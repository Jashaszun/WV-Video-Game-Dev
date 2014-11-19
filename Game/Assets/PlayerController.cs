using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	GameObject mainCamera;
	const float VELOCITY = 3;

	// Use this for initialization
	void Start()
	{
		mainCamera = GameObject.Find("Camera");
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

		rigidbody.velocity = (velX == 0 && velY == 0)
			? Vector3.zero
				: (new Vector3(velX, velY).normalized * VELOCITY);

		// update camera to follow player.
		mainCamera.transform.position = new Vector3(
			transform.position.x,
			transform.position.y,
			mainCamera.transform.position.z);
	}
}
