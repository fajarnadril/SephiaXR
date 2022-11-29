using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GantiKameraAR : MonoBehaviour
{
    
    public Camera componentARCamera;
    public GameObject bgMenu;
    public GameObject VRcamera;
    //public GameObject imgVRviewL, imgVRviewR;
    public GameObject buttonAR, buttonVR;
    void Start()
    {
        KameraAR();
        
    }

    // Update is called once per frame
    public void KameraAR()
    {
        VRcamera.SetActive(false);
        //imgVRviewL.SetActive(false);
        //imgVRviewR.SetActive(false);
        componentARCamera.enabled = true;
        buttonAR.SetActive(false);
        buttonVR.SetActive(true);
        bgMenu.SetActive(true);
    }

    public void KameraVR()
    {
        componentARCamera.enabled = false;
        VRcamera.SetActive(true);
        //imgVRviewL.SetActive(true);
        //imgVRviewR.SetActive(true);
        buttonAR.SetActive(true);
        buttonVR.SetActive(false);
        bgMenu.SetActive(false);

    }
}
