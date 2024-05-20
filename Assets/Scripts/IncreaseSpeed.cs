using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSpeed : Collectible
{
    public float speedIncrease = 10f;
    

    public override void Collected(Player player)
    {
        base.Collected(player);
        float currentSpeed = player.GetComponent<FirstPersonController>().MoveSpeed;
        currentSpeed += speedIncrease;
        player.GetComponent<FirstPersonController>().MoveSpeed = currentSpeed;
        Debug.Log(currentSpeed);
        
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
