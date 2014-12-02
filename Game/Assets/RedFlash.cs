using UnityEngine;
using System.Collections;

public class RedFlash : MonoBehaviour
{
	private static GUITexture red;

	public const float TOTAL_TIME = 1;
	private static float elapsedTime;
	private static bool flashing = false;

	void Start()
	{
		red = GameObject.Find("RedScreen").GetComponent<GUITexture>();
		Update(); // to set texture alpha to 0 at beginning
	}
	
	// Update is called once per frame
	void Update()
	{
		if (flashing)
		{
			elapsedTime += Time.deltaTime;
			if (elapsedTime >= TOTAL_TIME)
				flashing = false;
		}

		float alpha;
		if (flashing)
			alpha = Mathf.Lerp(.5f, 0, elapsedTime / TOTAL_TIME);
		else alpha = 0;

		red.color = new Color(1, 1, 1, alpha);
	}

	public static void Flash()
	{
		elapsedTime = 0;
		flashing = true;
	}
}
