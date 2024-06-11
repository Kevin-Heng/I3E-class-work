using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleBox : Collectible
{
    [SerializeField] GameObject collectibleToSpawn;
    public AudioClip openBox;

    void SpawnCollectible()
    {
        Instantiate(collectibleToSpawn, transform.position, collectibleToSpawn.transform.rotation);
        
    }

    public override void Collected(Player player)
    {
        SpawnCollectible();
        AudioSource.PlayClipAtPoint(openBox, transform.position, 1f);
        base.Collected(player);

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
