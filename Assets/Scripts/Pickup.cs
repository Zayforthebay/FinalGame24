using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public float rotateSpeed = 5f; // controls speed of rotation 
    public int pointvalue = 1; //Value to increase points by 
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")) // If the "other" collider hits this game object, check tag to see if it is "Player"
        {
            //GameManager.Instance.UpdateScore(pointvalue);
            Destroy(this.gameObject);//Destroy pickup 
        }
    } //OnTriggerEnter is called when a Trigger collider collides with another collider

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      transform.Rotate(new Vector3(15,30,45) *rotateSpeed * Time.deltaTime);//Time.deltaTime makes the object frame dependent   
    }
}

