using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    //public string Scene;

    private void newScene() 
    {
        SceneManager.LoadScene("NivelSelva");
    }
}
