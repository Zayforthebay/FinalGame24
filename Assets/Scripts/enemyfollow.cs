using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class enemyfollow : MonoBehaviour
{

    private UnityEngine.AI.NavMeshAgent agent;

    public Transform target;

    void Awake()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null) // if this enemy has a target to follow
        {
            agent.SetDestination(target.position); // Set that target current position as this enemy's destination
        }
    
    }
        
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) // If the object this enemy just hit is the player
        {
            // Despawn the player and tell the Gamemanger to reset the current level
            Destroy(other.gameObject);
           // GameManager.Instance.GameOver();
        }
    }
}
