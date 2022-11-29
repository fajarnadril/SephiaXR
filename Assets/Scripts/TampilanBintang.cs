using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TampilanBintang : MonoBehaviour
{
    //public GameObject[] bintangObject;

    PengaturWaktu pengaturWaktu;
    public GameObject imgSuccess, imgFailed, finishMesh, imageTarget1;
    
    void Start()
    {
        pengaturWaktu = this.gameObject.GetComponent<PengaturWaktu>();
        imgSuccess.SetActive(false);
        imgFailed.SetActive(false);
    }
    public void MunculBintang ()
    {
        if (pengaturWaktu.bintang == 3)
        {
            imgSuccess.SetActive(true);
            finishMesh.SetActive(false);
            imageTarget1.SetActive(false);
            //Instantiate(bintangObject[3]);
            //Debug.Log("Instantiate Bintang 3");
        }
        else if (pengaturWaktu.bintang == 2)
        {
            imgSuccess.SetActive(true);
            finishMesh.SetActive(false);
            imageTarget1.SetActive(false);
            //Instantiate(bintangObject[2]);
            //Debug.Log("Instantiate Bintang 2");
        }
        else if (pengaturWaktu.bintang == 1)
        {
            imgSuccess.SetActive(true);
            finishMesh.SetActive(false);
            imageTarget1.SetActive(false);
            //Instantiate(bintangObject[1]);
            //Debug.Log("Instantiate Bintang 2");
        }
        else if (pengaturWaktu.bintang == 0)
        {
            imgFailed.SetActive(true);
            finishMesh.SetActive(false);
            imageTarget1.SetActive(false);
            //Instantiate(bintangObject[0]);
            //Debug.Log("Instantiate Bintang 0");
        }
    }
   

}
