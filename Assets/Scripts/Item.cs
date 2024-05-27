using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Item : Collectible
{
    public int points = 10;

    public override void Collected(Player player)
    {
        base.Collected(player);
        GameManager.Instance.IncreaseScore(points);
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
