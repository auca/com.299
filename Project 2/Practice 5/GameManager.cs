using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	public bool IsPaused = true;

	public GameObject menu;

	void Awake() {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}

		DontDestroyOnLoad (gameObject);
	}

	void Update() {
		if (Input.GetKeyUp (KeyCode.Escape)) {
			Pause ();
		}
	}

	public void Exit() {
		Application.Quit ();
	}

	public void Play() {
		IsPaused = false;
		menu.SetActive(false);
	}

	public void Pause() {
		IsPaused = true;
		menu.SetActive(true);
	}

}
