using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuChooseMapController : MonoBehaviour
{
    public GameObject manager;
    public void Map1(){
        SceneManager.LoadScene("Level1");
    }
    public void Map2(){
        SceneManager.LoadScene("Level2");
    }
    public void Map3(){
        SceneManager.LoadScene("Level3");
    }
    public void Map4(){
        SceneManager.LoadScene("Level4");
    }
    public void Map5(){
        SceneManager.LoadScene("Level5");
    }
    public void Map6(){
        SceneManager.LoadScene("Level6");
    }
    public void Map7(){
        SceneManager.LoadScene("Level7");
    }
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
