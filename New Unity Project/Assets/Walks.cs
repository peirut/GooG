using UnityEngine;
using System.Collections;

public class Walks : MonoBehaviour
{
	public Rigidbody body;
	public float speed = 10.0f;
	public float jumpHeight = 5.0f;
	Vector3 standardMovement;
	Vector3 jumpMovement;
	public bool isGrounded = true;

	// Use this for initialization
	void Start ()
	{
		standardMovement = new Vector3 (speed, 0.0f, 0.0f);
		jumpMovement = new Vector3 (speed, jumpHeight, 0.0f);
		body = GetComponent<Rigidbody> ();
		body.velocity = standardMovement;

	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		standardMovement.x += 0.001f;
		isGrounded = Physics.Raycast (transform.position, Vector3.down, .51f);
		//Insert Boost Movement

		//Insert Left/Right Movement
		if ((isGrounded) && Input.GetKey (KeyCode.Space)) {
			body.velocity = jumpMovement;
		} else if (isGrounded) {
			body.velocity = standardMovement;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (0, 0, .1f);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (0, 0, -.1f);
		}
	}
	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "Net")
			Application.LoadLevel ("Sceeeeeeeeeene");
		if (col.gameObject.tag == "Obstacle") {
			if (col.contacts [0].normal.y <= 0)
        
				Application.LoadLevel ("Sceeeeeeeeeene");
		}
	}
}
