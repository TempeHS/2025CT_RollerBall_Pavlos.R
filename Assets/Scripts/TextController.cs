using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextController : MonoBehaviour
{
    // Start is called before the first frame update

    private int Scene;

    [SerializeField] private GameObject main;
    [SerializeField] private GameObject modes;

    void start() {
        Scene = 1;
        Back();
    }

    public void playGame()
    {
        SceneManager.LoadScene(Scene);
    }

    public void GameModes() {

        modes.SetActive(true);
        main.SetActive(false);
    }

    public void Dark() {
        Scene = 2;
    }

    public void Normal() {
        Scene = 1;
    }

    public void Back() {
        modes.SetActive(false);
        main.SetActive(true);
    }
}
