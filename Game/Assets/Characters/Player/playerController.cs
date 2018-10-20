using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public float speed;

	private Rigidbody2D rb2d;
	public GameObject portal;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		portal = GameObject.FindWithTag("Finish");
	}

	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector2 movement = new Vector2(moveHorizontal, moveVertical);

		rb2d.AddForce(movement*speed);

	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.CompareTag("egg")){
			other.gameObject.SetActive(false);
			portal.SetActive(true);
		}
	}
}
