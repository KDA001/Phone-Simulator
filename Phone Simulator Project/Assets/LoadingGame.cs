using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingGame : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadScene("Menu");
    }
}
