using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Material material;

    [SerializeField] private float speed;
    [SerializeField] private Rigidbody PlayerRGDBody;
    [SerializeField] private int score;
    [SerializeField] private float DeathCounter;
    [SerializeField] private float deathAnimation;

    [SerializeField] private int health = 1;

    private bool CanMove;

    public TextMeshProUGUI Counter;

    public GameObject You_Lose;
    public GameObject You_Win;
    public GameObject Enemies;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRGDBody = GetComponent<Rigidbody>();
        CounterChange();
        CanMove = true;

        health = 1;

        You_Lose.SetActive(false);
        You_Win.SetActive(false);
        Enemies.SetActive(true);

        deathAnimation = 1f;


        material = GetComponent<MeshRenderer>().material;

        DeathCounter = 0f;
    }

    void CounterChange()
    {
        Counter.text = "Score: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {


        if (health <= 0)
        {
            CanMove = false;


            if (DeathCounter <= 1f)
            {
                DeathCounter += Time.deltaTime;
                deathAnimation -= Time.deltaTime;
            }
            else
            {
                You_Lose.SetActive(true);
                Destroy(gameObject);
            }
        }

        if(score >= 16)
        {
            You_Win.SetActive(true);
            Enemies.SetActive(false);
        }



    }

    void FixedUpdate() 
    {

        material.SetFloat("_Fade", deathAnimation);






    }

    public void Move(float horizontal, float vertical) 
    {

        if(CanMove == true)
        {
            Vector3 targetVelocity = new Vector3(horizontal, 0.0f, vertical);
            targetVelocity = targetVelocity.normalized * speed;

            PlayerRGDBody.AddForce(targetVelocity);
        }

    }

    private void OnTriggerEnter(Collider collision) {

        if(collision.gameObject.tag == "Collectible") 
        {

            score += 1;
            Destroy(collision.gameObject);

            CounterChange();
        }

    }

    private void OnCollisionEnter(Collision collider)
    {
        if(collider.gameObject.tag == "Enemy")
        {
            health -= 1;
        }
    }
}
