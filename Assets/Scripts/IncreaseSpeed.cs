using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSpeed : Collectible
{
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            UpdatePlayerInterractable(other.gameObject.GetComponent<Player>());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            RemovePlayerInterractable(other.gameObject.GetComponent<Player>());
        }
    }

    public override void Collected(Player player)
    {
        base.Collected(player);
        float currentSpeed = player.GetComponent<StarterAssets.FirstPersonController>().MoveSpeed;
        currentSpeed += 20;
        Debug.Log("Player speed is now " + currentSpeed);

    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
