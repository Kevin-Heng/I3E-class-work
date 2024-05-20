using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
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

    public void UpdatePlayerInterractable(Player player)
    {
        player.UpdateCollectible(this);
    }

    public void RemovePlayerInterractable(Player player)
    {
        player.UpdateCollectible(null);
    }
    public virtual void Collected(Player player)
    {
        Debug.Log("collected");
        Destroy(gameObject);
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
