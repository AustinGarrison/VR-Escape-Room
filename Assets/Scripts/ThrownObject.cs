using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrownObject : MonoBehaviour
{
    public GameObject fractured;
<<<<<<< Updated upstream

    public void BreathTheThing()
    {
        Instantiate(fractured, transform.position, transform.rotation);
=======
    public GameObject hidden;

    public void BreakTheThing()
    {
        Instantiate(fractured, transform.position, transform.rotation);
        Instantiate(hidden, transform.position, transform.rotation);
>>>>>>> Stashed changes
        Destroy(gameObject);
    }
}
