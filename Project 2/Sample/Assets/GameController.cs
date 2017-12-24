using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public static GameController instance;
    public GameObject Menu;

    [HideInInspector]
    public bool IsPaused;

    void Awake () {
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy (gameObject);
        }

        DontDestroyOnLoad (gameObject);
    }

    public void Start () {
        Pause ();
    }

    public void Play () {
        IsPaused = false;
        HideMenu ();
    }

    public void Pause () {
        IsPaused = true;
        ShowMenu ();
    }

    public void Exit () {
        Application.Quit ();
    }

    void ShowMenu () {
        foreach(Button selectable in Menu.GetComponentsInChildren<Button>()) {
            selectable.interactable = true;
        }

        foreach(Graphic graphic in Menu.GetComponentsInChildren<Graphic>()) {
            graphic.CrossFadeAlpha (1.0f, 1.0f, false);
        }
    }

    void HideMenu () {
        foreach(Button selectable in Menu.GetComponentsInChildren<Button>()) {
            selectable.interactable = false;
        }

        foreach(Graphic graphic in Menu.GetComponentsInChildren<Graphic>()) {
            graphic.CrossFadeAlpha (0.0f, 1.0f, false);
        }
    }

    void Update () {
        if (Input.GetKeyUp(KeyCode.Escape)) {
            if (IsPaused) {
                Play ();
            } else {
                Pause ();
            }
        }
    }

}
