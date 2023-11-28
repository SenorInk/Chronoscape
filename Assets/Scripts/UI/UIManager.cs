using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private GameObject QuizManagers;
    

    private void Awake() 
    {
        gameOverScreen.SetActive(false);
        QuizManagers.SetActive(false);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        QuizManagers.SetActive(false);
    }

    public void StarQuiz()
    {
        QuizManagers.SetActive(true);
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
