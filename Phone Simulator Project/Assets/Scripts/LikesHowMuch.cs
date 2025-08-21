using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LikesHowMuch : MonoBehaviour
{
    private int likes_int;
    private Text HowMuchtext;
    void Start()
    {
        HowMuchtext = GetComponent<Text>();
        likes_int = Random.Range(1000, 5000);
        HowMuchtext.text = likes_int.ToString();
    }
    public void Like_click()
    {
        likes_int++;
        HowMuchtext.text = likes_int.ToString();
    }
    public void DisLike_click()
    {
        likes_int--;
        HowMuchtext.text = likes_int.ToString();
    }
}
