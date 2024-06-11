using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Item : Collectible
{
    public int points = 10;
    public AudioClip collectCollectible;

    public override void Collected(Player player)
    {
        AudioSource.PlayClipAtPoint(collectCollectible, transform.position, 1f);
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
