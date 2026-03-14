using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
 public void PlayGame()
    {
        SceneManager.LoadSceneAsync("PlayScene");
    }
public void OpenOptions()
    {
        SceneManager.LoadSceneAsync("OptionsPanel");
       
    }
    

    // Exit Button
    public void QuitGame()
    {
        Application.Quit();
    }
}
