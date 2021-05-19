using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public Text counterText;
    // Start is called before the first frame update
    public float startTime;
    private static bool finnished=false;
    

    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (finnished) return;
        
        float t = Time.time - startTime;
        string seconds = (t % 60f).ToString("00");
        string miliSeconds = ((t * 1000f) % 1000).ToString("00");
        counterText.text = "Time: " + seconds + ":" + miliSeconds;
        
    }

    public static void Finnish() 
    {
        finnished = true;
    }
 }