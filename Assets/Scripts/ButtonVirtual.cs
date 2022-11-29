using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonVirtual : MonoBehaviour
{
    [SerializeField] TampilanBintang tampilanBintang;
    public VirtualButtonBehaviour vb1;
    public VirtualButtonBehaviour vb2;
    public GameObject cube;
    [SerializeField] bool isActive;
    // Start is called before the first frame update
    void Start()
    {
        cube.SetActive(false);
        vb1.RegisterOnButtonPressed(OnButtonPressed);
        vb2.RegisterOnButtonPressed(OnButtonPressed);
    }

   public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (isActive == false)
        {
            Debug.Log("hidup");
            cube.SetActive(true);
            isActive = true;
        }
        else
        {
            Debug.Log("mati");
            cube.SetActive(false);
            isActive = false;
        } 
    }

    
}
