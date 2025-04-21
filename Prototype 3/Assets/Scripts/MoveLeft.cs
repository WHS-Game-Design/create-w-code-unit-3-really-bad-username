using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    // Start is calre the first frame update
    private PlayerController playerController; 
    [SerializeField] private float speed = 15f;
    [SerializeField] private float leftBound  = -15f; 
    // Update is called once per frame
    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }

    void Update()
    { 
      if(!playerController.gameIsActive) 
      return;
      transform.Translate(speed * Time.deltaTime * Vector3.left);   

      if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
      Destroy(gameObject);
    }
}
