using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFieldView : MonoBehaviour
{
    public float povNilai;
    void Awake()
    {
        StartCoroutine(Wait());
        Debug.Log("start camera");
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("start camera after brp detik");
        //this.GetComponent<Camera>().fieldOfView = GameObject.Find("ARCamera").GetComponent<Camera>().fieldOfView;
        this.GetComponent<Camera>().fieldOfView = povNilai;
    }
}
