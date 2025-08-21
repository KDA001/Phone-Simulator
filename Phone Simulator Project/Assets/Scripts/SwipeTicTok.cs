using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class SwipeTicTok : MonoBehaviour
{
    [Range(1, 10)]
    [Header("Controllers")]
    public int panCount;
    [Range(0, 5000)]
    public int panOffset;
    [Range(0f, 20f)]
    public float snapSpeed;
    [Range(0f, 5f)]
    public float scaleOffset;

    [Header("Other Objects")]
    public GameObject panPrefab;
    public VideoClip[] VideosTikTok;

    private GameObject[] instPans;
    private Vector3[] panPos;
    private Vector3[] panScale;

    private RectTransform contentRect;
    private Vector3 contentVector;

    private int selectedPanID;
    private bool isScroling;
    private void Awake()
    {
        contentRect = GetComponent<RectTransform>();
        instPans = new GameObject[panCount];
        panPos = new Vector3[panCount];
        panScale = new Vector3[panCount];

        for(int i = 0; i < panCount; i++)
        {
            instPans[i] = Instantiate(panPrefab, transform, false);
            if (i == 0) continue;
            instPans[i].transform.localPosition = new Vector3(instPans[i].transform.localPosition.x, 
                instPans[i-1].transform.localPosition.y + panPrefab.GetComponent<RectTransform>().sizeDelta.y - panOffset);
            panPos[i] = -instPans[i].transform.localPosition;

            instPans[i].GetComponent<VideoPlayer>().clip = VideosTikTok[i];
        }
    }
    //private void Start()
    //{
    //    contentRect = GetComponent<RectTransform>();
    //    instPans = new GameObject[panCount];
    //    panPos = new Vector3[panCount];
    //    panScale = new Vector3[panCount];

    //    for (int i = 0; i < panCount; i++)
    //    {
    //        instPans[i] = Instantiate(panPrefab, transform, false);
    //        if (i == 0) continue;
    //        instPans[i].transform.localPosition = new Vector3(instPans[i].transform.localPosition.x,
    //            instPans[i - 1].transform.localPosition.y + panPrefab.GetComponent<RectTransform>().sizeDelta.y - panOffset);
    //        panPos[i] = -instPans[i].transform.localPosition;
    //    }
    //}

    private void FixedUpdate()
    {
        float nearestPos = float.MaxValue;

        for(int i = 0; i < panCount; i++)
        {
            float distance = Mathf.Abs(contentRect.anchoredPosition.y - panPos[i].y);
            if (distance < nearestPos)
            {
                nearestPos = distance;

                selectedPanID = i;
            }

            float scale = Mathf.Clamp(1 / (distance / panOffset)* scaleOffset, 0.5f, 1f);

            panScale[i].x = Mathf.SmoothStep(instPans[i].transform.localScale.x, scale, 6 * Time.fixedDeltaTime);
            panScale[i].y = Mathf.SmoothStep(instPans[i].transform.localScale.y, scale, 6 * Time.fixedDeltaTime);
            instPans[i].transform.localScale = panScale[i];
        }
        if (isScroling) return;
        contentVector.y = Mathf.SmoothStep(contentRect.anchoredPosition.y, panPos[selectedPanID].y, snapSpeed * Time.fixedDeltaTime);
        contentRect.anchoredPosition = contentVector;

        instPans[selectedPanID].GetComponent<VideoPlayer>().enabled = true;
        instPans[selectedPanID].GetComponent<RawImage>().enabled = true;

        instPans[selectedPanID].GetComponent<VideoPlayer>().Play();

        for(int i = 0; i< panCount; i ++)
        {
            if(i != selectedPanID)
            {
                instPans[i].GetComponent<VideoPlayer>().enabled = false;
                instPans[i].GetComponent<RawImage>().enabled = false;

                instPans[i].GetComponent<VideoPlayer>().frame = 0;
                instPans[i].GetComponent<VideoPlayer>().Pause();
            }
        }
    }

    public void Scrolling(bool scroll)
    {
        isScroling = scroll;
    }
}
