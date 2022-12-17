using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntrodutionController : MonoBehaviour
{
    public void ReturnMenu(){
        SceneManager.LoadScene("Menu");
    }
}
