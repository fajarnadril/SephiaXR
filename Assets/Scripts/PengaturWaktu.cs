using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PengaturWaktu : Waktu
{
    TampilanBintang tampilanBintang;
    public float setwaktuKuota;
     void Start()
    {
        waktuKuota = setwaktuKuota;
        tampilanBintang = GetComponent<TampilanBintang>();
    }


    public void FungsiWaktuJalan()
    {
        
        ResetWaktu();
        isWaktuJalan = true;
        
    }

    public void FungsiWaktuSelesai()
    {
        isWaktuJalan = false;
        ResetWaktu();
        tampilanBintang.MunculBintang();
       

    }

}
