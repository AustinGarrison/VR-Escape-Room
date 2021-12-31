using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WatchTimer : MonoBehaviour
{
    [SerializeField] TMP_Text averageFPSDisplay;
    int framesPassed = 0;
    float fpsTotal = 0f;


    // Start is called before the first frame update
    void Start()
    {
        averageFPSDisplay.text = "10";
    }

    // Update is called once per frame
    void Update()
    {
        float fps = 1 / Time.unscaledDeltaTime;
        averageFPSDisplay.text = "" + fps;

        fpsTotal += fps;
        framesPassed++;
        averageFPSDisplay.text = "" + (fpsTotal / framesPassed);
    }
}
