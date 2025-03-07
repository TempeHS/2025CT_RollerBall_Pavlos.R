using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private int Scene;

    [SerializeField] private GameObject main;
    [SerializeField] private GameObject modes;

    [SerializeField] private GameModesScript gameMode;

    void Start() {
        Scene = 1;
    }

    public void playGame()
    {
        SceneManager.LoadScene(gameMode.Scene);
    }

    public void GameModes() {

        modes.SetActive(true);
        main.SetActive(false);
    }


}
