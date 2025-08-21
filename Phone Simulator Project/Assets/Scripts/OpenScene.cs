using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenScene : MonoBehaviour
{
    public FadeInOut _fadeInOut;
    public void _indexPlayScene(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void PlayScene(int indexNextScene)
    {
        _fadeInOut.nextLevel = indexNextScene;
        FadeInOut.sceneEnd = true;
    }
}
