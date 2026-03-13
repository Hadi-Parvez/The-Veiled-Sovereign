using UnityEngine;
using UnityEngine.SceneManagement;
public class Options : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void BackToMenu()
    {
        SceneManager.LoadSceneAsync("Main Menu");
    }
    public void Volume(){
        SceneManager.LoadSceneAsync("SoundOptions");
    }
    public void Display(){
        SceneManager.LoadSceneAsync("DisplayOptions");
    }
    public void Graphics(){
        SceneManager.LoadSceneAsync("GraphicsOptions");
    }
    public void KeyBinds(){
        SceneManager.LoadSceneAsync("KeyBindOptions");
    }
}
