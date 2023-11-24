using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    private Transform currentCheckpoint;
    private Health playerHealth;
    private UIManager uiManager;

    public GameObject fallDetector;

    private void Awake()
    {
        playerHealth = GetComponent<Health>();
        uiManager = FindObjectOfType<UIManager>();
    }

    public void CheckRespawn()
    {
        if(currentCheckpoint == null)
        {
            uiManager.GameOver();
            return;
        }
        
        playerHealth.Respawn();
        transform.position = currentCheckpoint.position;    
   
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.transform.tag == "Checkpoint")
        {
            currentCheckpoint = collision.transform;
            collision.GetComponent<Collider2D>().enabled = false;
            collision.GetComponent<Animator>().SetTrigger("appear");
        }
        if(collision.transform.tag == "FallDetector")
        {
            uiManager.GameOver();
            return;
        }
         
    }
    void Update() 
    {
        fallDetector.transform.position = new Vector2(transform.position.x, fallDetector.transform.position.y);
    }
}
