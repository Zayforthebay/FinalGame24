using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
     //How to make a variable in C#:
   public CharacterController controller; // A var that holds the character’s character controller component.
   public float moveSpeed = 5f;
   private Vector3 moveDirection = Vector3.zero;
   private int score;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>(); //Assign controller to character controller
    }
    // Update is called once per frame
    void Update()
    {
        //Player movement input
       float horizontalInput = Input.GetAxis("Horizontal"); //Left and right input from the player
       float verticalInput = Input.GetAxis("Vertical"); //Forward and backward input from the player
        //Calculate the players movement direction
       Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);
       //Move player based on the input
       controller.Move(movement * moveSpeed * Time.deltaTime);
    }
     private void OnTriggerEnter(Collider other)
    {
        
    }
}