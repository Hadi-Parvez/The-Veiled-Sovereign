using UnityEngine;
using UnityEngine.SceneManagement;

public class DisplayOption : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void BackToOption(){

       SceneManager.LoadSceneAsync("OptionsPanel");
    
   }
}
