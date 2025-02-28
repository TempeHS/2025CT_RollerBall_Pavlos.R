using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private Rigidbody PlayerRGDBody;
    [SerializeField] private int score;

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

    public void Move(float horizontal, float vertical) 
    {
        Vector3 targetVelocity = new Vector3(horizontal, PlayerRGDBody.velocity.y, vertical);
        targetVelocity = targetVelocity.normalized * speed;
        
        PlayerRGDBody.AddForce(targetVelocity);
    }

    private void OnTriggerEnter(Collider collision) {

        if(collision.gameObject.tag == "Collectible") 
        {

            score += 1;
            Destroy(collision.gameObject);
        }

    }
}
