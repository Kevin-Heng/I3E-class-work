using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseJump : Collectible
{
    float increaseJump = 10f;

    public override void Collected(Player player)
    {
        base.Collected(player);
        float currentJumpHeight = player.GetComponent<FirstPersonController>().JumpHeight;
        currentJumpHeight += increaseJump;
        Debug.Log(currentJumpHeight);
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
