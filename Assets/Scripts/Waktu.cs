using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waktu : MonoBehaviour
{
    public float waktuBerjalan;
    public static float waktuKuota;
    public static bool isWaktuJalan;
    public int bintang;

    void Update()
    {
        if (isWaktuJalan == true)
        {
            Debug.Log("Bintang;" + bintang);
            FungsiWaktu();
            FungsiTanpaBintang();
            //FungsiPerhitunganBintang(); //kalau pakai score

        }
    }

    public void ResetWaktu()
    {
        waktuBerjalan = waktuKuota;
    }

    public void FungsiWaktu ()
    {
        waktuBerjalan = waktuBerjalan - Time.deltaTime;
    }

    public void FungsiPerhitunganBintang()
    {
        if (waktuBerjalan > 7 && waktuBerjalan < 10)
        {
            //Debug.Log("bintang 3");
            bintang = 3;
        }
        else if (waktuBerjalan > 4 && waktuBerjalan < 7)
        {
            //Debug.Log("bintang 2");
            bintang = 2;
        }
        else if (waktuBerjalan > 1 && waktuBerjalan < 4)
        {
            //Debug.Log("bintang 1");
            bintang = 1;
        }
        else if (waktuBerjalan < 1)
        {
            //Debug.Log("bintang 1");
            bintang = 0;
        }
    }

    public void FungsiTanpaBintang()
    {

        if (waktuBerjalan > 0)
        {
            //Debug.Log("bintang 1");
            bintang = 1;
        }
        else
        {
            //Debug.Log("bintang 1");
            bintang = 0;
        }
    }

}


