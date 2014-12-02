using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour
{
	public const float SPEED = 5;

	void Start()
	{

	}
	
	// Update is called once per frame
	void Update()
	{

	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Wall")
			Destroy(this.gameObject);
	}
}
