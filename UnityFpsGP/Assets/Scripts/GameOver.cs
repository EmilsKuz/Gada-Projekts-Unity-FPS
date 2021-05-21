using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text timeText;
    public void GOver(string time)
    {
        Cursor.lockState = CursorLockMode.None;
        gameObject.SetActive(true);
        timeText.text = "Your time: " + time;
    }

    public void RestartButton() {
        SceneManager.LoadScene("MainScene");
    }
    public void MainMenu() {
        SceneManager.LoadScene("MainMenu");

    }
}