using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMode : MonoBehaviour
{
   public GameObject mainMenuPanel;
   public GameObject playModePanel;
   public void showPanel(){
      mainMenuPanel.SetActive(false);
      playModePanel.SetActive(true);
   }
   public void Play (){
        SceneManager.LoadSceneAsync("MainScene");
    }
    public void NewGame(){

    }
    public void LoadGame(){

    }
   public void BackToMenu(){
    mainMenuPanel.SetActive(true);
    playModePanel.SetActive(false);
   }
}
