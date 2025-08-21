using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class ConnectingCheck : MonoBehaviour
{
    public GameObject NoConnectingUI;

    private void Start()
    {
        StartCoroutine(verifyInternetConnection());
    }
    IEnumerator verifyInternetConnection()
    {
        UnityWebRequest www = new UnityWebRequest("https://google.com");
        yield return www.SendWebRequest();
        if(www.isNetworkError)
        {
            NoConnectingUI.SetActive(true);
        }
        else
        {
            NoConnectingUI.SetActive(false);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
