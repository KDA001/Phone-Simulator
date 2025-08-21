using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class CameraShot : MonoBehaviour
{
    public RawImage RImage;
    public RenderTexture RTexture;
    private IEnumerator CoSave()
    {
        // ждем для рендеринга
        yield return new WaitForEndOfFrame();
        Debug.Log(Application.dataPath + "/savedImage.png");

        // даем активную текстуру
        RenderTexture.active = RTexture;

        // конвертируем renderTexture на texture2D
        var texture2D = new Texture2D(RTexture.width, RTexture.height);
        texture2D.ReadPixels(new Rect(0, 0, RTexture.width, RTexture.height), 0, 0);
        texture2D.Apply();

        RImage.texture = texture2D;
        // сохранить данные в файл
        //var data = texture2D.EncodeToPNG();
        //File.WriteAllBytes(Application.dataPath + "/saveImage.png", data);
    }
    public void Save()
    {
        StartCoroutine(CoSave());
        //StartCoroutine(setImage());
    }

    private IEnumerator setImage()
    {
        yield return new WaitForEndOfFrame();
        Texture2D texture2D = new Texture2D(RTexture.width, RTexture.height);
        //string path = Application.persistentDataPath + "/saveImage.png";
        string path = Application.dataPath + "/saveImage.png";
        byte[] bytes = File.ReadAllBytes(path);

        texture2D.LoadImage(bytes);
        texture2D.Apply();
        RImage.texture = texture2D;
    }
}
