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
            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60f).ToString("f2");
            counterText.text = "Time: " + minutes + ":" + seconds;
            currTime = minutes + ":" + seconds;
        }
    }

    public void Finnish() 
    {
        finnished = true;
        GameOver.GOver(currTime);
    }
 }