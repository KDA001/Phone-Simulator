using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On_Off_Phone : MonoBehaviour
{
    public MeshRenderer Display;

    public GameObject SystemOS;
    public GameObject Lock;
    public GameObject UnLock;
    public GameObject Menu;

    public bool isOnPhone = true;

    [Header("On")]
    public Material Display_On;


    [Header("Off")]
    public Material Display_Off;


    public void _on()
    {
        isOnPhone = true;
        Display.material = Display_On;

        for (int i = 0; i < SystemOS.transform.childCount; i++)
        {
            SystemOS.transform.GetChild(i).gameObject.SetActive(false); 
        }

        for (int i = 0; i < Lock.transform.childCount; i++)
        {
            Lock.transform.GetChild(i).gameObject.SetActive(true); 
        }

        for (int i = 0; i < UnLock.transform.childCount; i++)
        {
            UnLock.transform.GetChild(i).gameObject.SetActive(false); 
            Menu.active = true;
        }

        SystemOS.active = true;
        Lock.active = true;
    }
    public void _off()
    {
        isOnPhone = false;

        Display.material = Display_Off;


        for (int i = 0; i < SystemOS.transform.childCount; i++)
        {
            SystemOS.transform.GetChild(i).gameObject.SetActive(false);
        }

        for (int i = 0; i < Lock.transform.childCount; i++)
        {
            Lock.transform.GetChild(i).gameObject.SetActive(true);
        }

        for (int i = 0; i < UnLock.transform.childCount; i++)
        {
            UnLock.transform.GetChild(i).gameObject.SetActive(false);
            Menu.active = true;
        }

        SystemOS.active = false;
        Lock.active = true;
    }
}
