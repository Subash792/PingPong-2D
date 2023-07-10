using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class Gamemanager : MonoBehaviour
{

    public int player;
    public int computer;
    public Ball_movement ball;
    public Text playerScoretxt;
    public Text computerScoretxt;
    public UnityEvent scenechange;
    public GameOver g;




    void Start()
    {
        player = 0;
        computer= 0;


    }

    public void playerscores()
    {
        player++;
        this.ball.reset_ball();
        this.playerScoretxt.text = player.ToString();
        Debug.Log("Player Scores");
        
        
        
    }
    public void computerscores()
    {
        computer++;
        this.ball.reset_ball();
        this.computerScoretxt.text = computer.ToString();
        Debug.Log("Computer Scores");

    }
    public void Gotomainmenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public IEnumerator PauseGame(float pauseTime)
    {
        Debug.Log("Inside PauseGame()");
        Time.timeScale = 0f;
        float pauseEndTime = Time.realtimeSinceStartup + pauseTime;
        while (Time.realtimeSinceStartup < pauseEndTime)
        {
            yield return 0;
        }
        Time.timeScale = 1f;
        Debug.Log("Done with my pause");

    }

    public void endgame()
    {   if (computer==5 || player == 5)
        {
            
            StartCoroutine(PauseGame(5f));

            Gotomainmenu();
        }
        
    }
    


    


}
