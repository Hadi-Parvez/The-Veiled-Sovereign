using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    private bool isPaused = false;
    public void Pause(){
   
         if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                ResumeGame();
            else
                PauseGame();
        }
    }
   
   public void PauseGame(){
        pauseMenu.SetActive(true);   // Show panel
        Time.timeScale = 0f;         // Pause game
        isPaused = true;
    }

    public void ResumeGame(){
        pauseMenu.SetActive(false);  // Hide panel
        Time.timeScale = 1f;         // Resume game
        isPaused = false;
    }
    public void BackToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadSceneAsync("Main Menu");
    }
}
