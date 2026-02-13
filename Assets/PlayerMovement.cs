using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed = 5f;

	void Update()
	{
		float x = Input.GetAxis("Horizontal");
		float y = Input.GetAxis("Vertical");

		transform.Translate(new Vector2(x,y) * speed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("Pickup"))
		{
			FindObjectOfType<GameManager>().PickupCollected();
			Destroy(other.gameObject);
		}
	}

}

