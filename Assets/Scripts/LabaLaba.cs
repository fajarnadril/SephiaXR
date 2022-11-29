using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabaLaba : MonoBehaviour
{

    [SerializeField] bool hasEntered = false;
    PengaturWaktu pengaturWaktu;
    GameObject gameManager;
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        pengaturWaktu = gameManager.GetComponent<PengaturWaktu>();
    }

    void SampaiFinish()
    {
        Debug.Log("Trigger!!!!!");
        pengaturWaktu.FungsiWaktuSelesai();
        Destroy(this.gameObject);
        hasEntered = true;
    }

    void OnCollisionEnter(Collision col)
    {
       
        if (hasEntered == false)
        {
            SampaiFinish();
        }
    }



}

