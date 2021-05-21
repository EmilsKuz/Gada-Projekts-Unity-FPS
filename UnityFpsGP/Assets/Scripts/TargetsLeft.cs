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
    // Update is called once per frame
    void Update()
    {
        //print("Target Count is" + targetCount); //indebugger you shout see 4 because thats what we told it to be in the variable
        targetText.text = "Targets left: " + targetCount;

        if (targetCount < 1)
        {
            
            Timer.Finnish();
        }
    }
}
