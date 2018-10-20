using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour {
	// Update is called once per frame
	public void startGame() {
		SceneManager.LoadScene("level1");
	}
}
