using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private Rigidbody PlayerRGDBody;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRGDBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() 
    {

    }

    public void Move(float speed) 
    {

    }
}
