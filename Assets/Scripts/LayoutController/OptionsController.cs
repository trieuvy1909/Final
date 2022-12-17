using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsController : MonoBehaviour
{
    public void Map8(){
        SceneManager.LoadScene("Level8");
    }
    public void Map9(){
        SceneManager.LoadScene("Level9");
    }
    public void Map10(){
        SceneManager.LoadScene("Level10");
    }
    public void ReturnMenu(){
        SceneManager.LoadScene("Menu");
    }
}
