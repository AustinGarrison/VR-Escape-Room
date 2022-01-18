using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForGround : MonoBehaviour
{
    bool isgrounded;
    public GameObject silhouette;

    void Start()
    {
        isgrounded = false;
        silhouette.SetActive(false);
    }

    void Update()
    {
        if (isgrounded == true)
        {
            silhouette.SetActive(true);
        }
        else
        {
            silhouette.SetActive(false);
        }
    }

    //make sure u replace "floor" with your gameobject name.on which player is standing
    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.layer == 8)
        {
            isgrounded = true;
        }
    }

    //consider when character is jumping .. it will exit collision.
    void OnCollisionExit(Collision theCollision)
    {
        if (theCollision.gameObject.layer == 8)
        {
            isgrounded = false;
        }
    }
}
