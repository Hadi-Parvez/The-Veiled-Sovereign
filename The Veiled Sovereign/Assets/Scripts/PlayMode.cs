using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMode : MonoBehaviour
{
   public void BackToMenu(){
    SceneManager.LoadSceneAsync("Main Menu");
   }
}
