using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class UIManager : MonoBehaviour

{
    public Button[] buttons;
    public Text scoreText;
    bool GameOver;
    int score;

    void Start()
    {
        GameOver = false;
        score = 0;
        InvokeRepeating("ScoreUpdate", 1.0f, 0.5f);
            
            
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    void ScoreUpdate() {
        if (GameOver == false)
        {
            score += 1;
        }
       
    }
    public void GameOverActivated() {
        GameOver = true;
        // Activating all the buttons
        // creating object of Button name button then storing all elements in buttons array.
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(true);
        }
    }

    public void StartGame() {
        Application.LoadLevel("GameScreen");
    }


    public void Pause() {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else if(Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }

    public void Replay() {

        Application.LoadLevel(Application.loadedLevel);
    }  
    public void Menu() {

        Application.LoadLevel("MenuScreen");
    }  public void EXIT() {

        Application.Quit();
    }
}
