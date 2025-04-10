using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{

    [SerializeField] private GameObject Main_Menu;
    [SerializeField] private GameObject Play_Again;

    public int Scene;
    // Start is called before the first frame update
    // Update is called once per 

    public void Menu()
    {
        SceneManager.LoadScene(0);

        Play_Again.SetActive(false);
        Main_Menu.SetActive(true);
    }

    public void Again()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        Play_Again.SetActive(false);
        Main_Menu.SetActive(true);
    }
}
