using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject manager;
    // Start is called before the first frame update
    public void PlayNewGame(){
        SceneManager.LoadScene("Level1");
    }
    public void ContinueGame(){
        SceneManager.LoadScene("MenuChosseMap");
    }
    public void Introduction(){
        SceneManager.LoadScene("introduction");
    }
    public void Option(){
        SceneManager.LoadScene("options");
    }
    public void QuitGame(){
        Application.Quit();
    }
}
