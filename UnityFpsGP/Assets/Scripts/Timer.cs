using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public Text counterText;
    public static float startTime;
    private static bool finnished=false;
    public static bool started = false;
    public GameOver GameOver;
    private static string currTime;
    

    void Start()
    {
        startTime = Time.time;
        finnished = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (finnished) return;
        if (started) { 
            float t = Time.time - startTime;
            string seconds = (t % 60f).ToString("00");
            string miliSeconds = ((t * 1000f) % 1000).ToString("00");
            counterText.text = "Time: " + seconds + ":" + miliSeconds;
            currTime = seconds + ":" + miliSeconds;
        }
    }

    public void Finnish() 
    {
        finnished = true;
        GameOver.GOver(currTime);
    }
 }