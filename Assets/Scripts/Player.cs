using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Collectible currentCollectible;

    public void UpdateCollectible(Collectible item)
    {
        currentCollectible = item;
    }
    void OnInteract()
    {
        if(currentCollectible != null)
        {
            currentCollectible.Collected();
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
