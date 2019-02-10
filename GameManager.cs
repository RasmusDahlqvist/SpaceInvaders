using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

     bool gameHasEnded = false; // sitä varten nä false pyörittelyt että peli loppuun vaan kerrans
    //public GameObject gameOverUI;
   // public GameObject gameWinUI;
    public GameObject pausePanel;
    public bool gamePaused;

   // public GameObject GameOverUI;
    public GameObject WINWONUI;

    void Start() {
        gamePaused = false;
    }

    public void LoadMenu() {
        SceneManager.LoadScene("StartMenu");
        // gameHasEnded = false;
        PlayerHealth.health = 3;
        

    }




    public void EndGame()
    {
        
        
            
            Debug.Log("Game Over");
            //GameOverUI.SetActive(true);
            //gamePaused = true;
            Time.timeScale = 0;
            Invoke("LoadMenu", 4f);
        
    }


    public void GameWon()
    {
        Debug.Log("You won the game");
        // gameWinUI.SetActive(true);
        //  gamePaused = true;

        // Time.timeScale = 0;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1); 
        Invoke("NextLevel", 2f);

    }

    public void NextLevel() {
        
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

       
    }

    public void Tryagainfalse() {
       // GameOverUI.SetActive(true);
    }

    public void ContinueButton(){
        
        gamePaused = false;
}


    public void TryAgainButton() {


        SceneManager.LoadScene("StartMenu");
    }

    void Update() {
      
        if (Input.GetKeyDown(KeyCode.P)) {

        gamePaused = !gamePaused;
        }
        if (gamePaused)
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0;
        }
        else if (!gamePaused) {
            pausePanel.SetActive(false);
            Time.timeScale = 1;

        }
    }


}
