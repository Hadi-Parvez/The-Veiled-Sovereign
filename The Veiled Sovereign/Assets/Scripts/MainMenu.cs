using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
 public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
public void OpenOptions()
    {
        SceneManager.LoadSceneAsync("OptionsPanel");
        // Or use scene index if you prefer
        // SceneManager.LoadSceneAsync(2);
    }
    

    // Exit Button
    public void QuitGame()
    {
        Application.Quit();
    }
}
