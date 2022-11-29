using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class MulaiVirtualButton : MonoBehaviour
{
    [SerializeField] PengaturWaktu pengaturWaktu;
    public VirtualButtonBehaviour vb1;
    public GameObject virtualButtonGO;
    public GameObject labaLaba;
    public GameObject imgLevel;
    void Start()
    {
        labaLaba.gameObject.SetActive(false);
        pengaturWaktu = GetComponent<PengaturWaktu>();
        vb1.RegisterOnButtonPressed(OnButtonPressed);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        pengaturWaktu.FungsiWaktuJalan();
        Debug.Log("HIDUUUUUP");
        Destroy(imgLevel);
        Destroy(virtualButtonGO);
        labaLaba.gameObject.SetActive(true);

    }
}
