using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text counterText;
    public float seconds, miliSeconds;
    // Start is called before the first frame update
    public static bool gameGood = true;
   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameGood) {
            miliSeconds = (int)(Time.time * 1000f) % 1000;
            seconds = (int)(Time.time % 60f);
            counterText.text = "Time: " + seconds.ToString("00") + ":" + miliSeconds.ToString("00");
        }
     
    }
}
