using UnityEngine;
using System.Collections;

public class PillarController : MonoBehaviour
{
	public Transform rightEndpoint;
	public Transform leftEndpoint;
	public float speed = 0.1f;

	private int direction = 1;

	// Update is called once per frame
	public void Update ()
	{
		transform.Translate (0, 0, direction * speed);

		if (transform.position.z >= rightEndpoint.localPosition.z + -2.5) {
			direction = -1;
		} else if (transform.position.z <= leftEndpoint.localPosition.z + -2.5)
			direction = 1;
	}
}
