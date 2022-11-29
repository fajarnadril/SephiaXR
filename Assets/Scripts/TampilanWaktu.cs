using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TampilanWaktu : MonoBehaviour
{

    //public Text UIWaktu;
    public TextMeshProUGUI UITMPWaktu;
    float menit;
    float detik;

    PengaturWaktu pengaturWaktu;
     void Start()
    {
        pengaturWaktu = this.gameObject.GetComponent<PengaturWaktu>();
    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log("waktu berjalan:" + waktuBerjalan);
        menit = Mathf.FloorToInt(pengaturWaktu.waktuBerjalan/60);
        detik = Mathf.FloorToInt(pengaturWaktu.waktuBerjalan % 60);

        // Debug.Log(menit + ":" + detik);
        //UIWaktu.text = menit.ToString()+" : "+ detik.ToString();

        // Debug.Log(menit + ":" + detik);
        UITMPWaktu.text = detik + " s ";
    }
}
