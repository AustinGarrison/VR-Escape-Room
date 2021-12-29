using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WatchTimer : MonoBehaviour
{
    [SerializeField] TMP_Text time;
    // Start is called before the first frame update
    void Start()
    {
        time.text = "10";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
