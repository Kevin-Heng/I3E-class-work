using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
   

    public void UpdatePlayerInteractable(Player player)
    {
        player.UpdateCollectible(this);
    }

    public void RemovePlayerInteractable(Player player)
    {
        player.UpdateCollectible(null);
    }
    public virtual void Collected(Player player)
    {
        Debug.Log("collected");
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            UpdatePlayerInteractable(other.gameObject.GetComponent<Player>());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            RemovePlayerInteractable(other.gameObject.GetComponent<Player>());
        }
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
