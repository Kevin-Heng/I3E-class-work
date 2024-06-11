using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    Collectible currentCollectible;
    [SerializeField]
    Transform playerCamera;
    [SerializeField]
    float interactionDistance;

    public TextMeshProUGUI interactText;

    public void UpdateCollectible(Collectible item)
    {
        currentCollectible = item;
    }
    void OnInteract()
    {
        if(currentCollectible != null)
        {
            currentCollectible.Collected(this);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(playerCamera.position, playerCamera.position + (playerCamera.forward * interactionDistance), Color.red);
        RaycastHit hitInfo;
        if(Physics.Raycast(playerCamera.position, playerCamera.forward, out hitInfo, interactionDistance))
        {
            if (hitInfo.transform.TryGetComponent<Collectible>(out currentCollectible)) //check if gameObject hit by ray has Collectible component script
            {
                interactText.gameObject.SetActive(true);
            }
            else //text is gone if game object hit by ray does not have Collectible component script
            {
                currentCollectible = null;
                interactText.gameObject.SetActive(false);
            }
        }
        else //no game object is hit by ray, text is goner
        {
            interactText.gameObject.SetActive(false);
        }
    }
}
