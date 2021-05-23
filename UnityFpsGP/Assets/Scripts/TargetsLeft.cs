using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetsLeft : MonoBehaviour
{
    public static int targetCount=5;
    public Text targetText;
    const bool end = false;
    public Timer Timer;
    private void Start()
    {
        targetCount = 5;
    }
    void Update()
    {
        targetText.text = "Targets left: " + targetCount;

        if (targetCount < 1)
        {
            Timer.Finnish();
        }
    }
}
