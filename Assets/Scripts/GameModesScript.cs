using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModesScript : MonoBehaviour
{

    [SerializeField] private GameObject main;
    [SerializeField] private GameObject modes;

    public int Scene;
    // Start is called before the first frame update
    void Start()
    {
        Scene = 1;
        Back();
    }

    // Update is called once per 

    public void Dark()
    {
        Scene = 2;

        modes.SetActive(false);
        main.SetActive(true);
    }

    public void Normal()
    {
        Scene = 1;
        
        modes.SetActive(false);
        main.SetActive(true);
    }

    public void Back()
    {
        modes.SetActive(false);
        main.SetActive(true);
    }
}
