using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    PlayerController controller;
    private Vector3 leftBound = new Vector3(-10, 0, 0);


    void Start()
    {
        controller = GameObject.Find("Player").GetComponent<PlayerController>();
    }

   
    void Update()
    {
        if(controller.gameOver == false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        
        if(transform.position.x < leftBound.x && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
