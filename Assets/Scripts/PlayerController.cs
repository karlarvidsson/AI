using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	void Update()
	{

	}

	public float speed;

	private int count;
	public Text text;

	void Start()
	{
		count = 0;
	}


	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rigidbody.AddForce (movement * speed * Time.deltaTime);
	}
	void OnTriggerEnter (Collider other)
	{
		//Destroy(other.gameObject);
		if (other.gameObject.tag == "PickUp") {
			other.gameObject.SetActive(false);	
			count++;
			text.text = "score: " + count;
		}
	}
}
