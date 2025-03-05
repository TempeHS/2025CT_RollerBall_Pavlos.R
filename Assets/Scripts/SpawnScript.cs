using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    public GameObject collectible; 
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(collectible, new Vector3(3f, 0.5f, 4f), Quaternion.identity);
        Instantiate(collectible, new Vector3(6f, 0.5f, 4f), Quaternion.identity);
        Instantiate(collectible, new Vector3(1f, 0.5f, 7f), Quaternion.identity);
        Instantiate(collectible, new Vector3(3f, 0.5f, 7f), Quaternion.identity);
        Instantiate(collectible, new Vector3(9f, 0.5f, 7f), Quaternion.identity);
        Instantiate(collectible, new Vector3(2f, 0.5f, 1f), Quaternion.identity);
        Instantiate(collectible, new Vector3(-4f, 0.5f, 7f), Quaternion.identity);
        Instantiate(collectible, new Vector3(-6f, 0.5f, 7f), Quaternion.identity);
        Instantiate(collectible, new Vector3(-8f, 0.5f, -6f), Quaternion.identity);
        Instantiate(collectible, new Vector3(-3f, 0.5f, -2f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
