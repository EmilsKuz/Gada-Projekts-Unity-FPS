using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetsLeft : MonoBehaviour
{
    public static int targetCount = 4;
    public Text targetText;
    const bool end = false;

    // Update is called once per frame
    void Update()
    {
        //print("Target Count is" + targetCount); //indebugger you shout see 4 because thats what we told it to be in the variable
        targetText.text = "Targets left: " + targetCount;

        if (targetCount < 1)
        {
            //Debug.Log("You Win!!!");
            
            Timer.gameGood = end;
        }
    }
}