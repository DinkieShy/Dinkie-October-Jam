using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour {

	public float speed;

	public int level;

	private Rigidbody2D rb2d;
	public Rigidbody2D portal;

	// Use this for initialization
	void Start () {
		Scene currentScene;
		currentScene = SceneManager.GetActiveScene();
		int.TryParse(currentScene.name[5].ToString(), out level);
		rb2d = GetComponent<Rigidbody2D>();
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
			portal.gameObject.SetActive(true);
		}
		else if(other.gameObject.CompareTag("Finish")){
			SceneManager.LoadScene("level" + ++level);
		}
	}
}
