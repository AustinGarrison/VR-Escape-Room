using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrownObject : MonoBehaviour
{
    public GameObject fractured;
    public GameObject hidden;

    public void BreakTheThing()
    {
        Instantiate(fractured, transform.position, transform.rotation);
        Instantiate(hidden, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
