using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMode : MonoBehaviour
{
   public void Play (){
        SceneManager.LoadSceneAsync("MainScene");
    }
    public void NewGame(){

    }
    public void LoadGame(){

    }
   public void BackToMenu(){
    SceneManager.LoadSceneAsync("Main Menu");
   }
}
