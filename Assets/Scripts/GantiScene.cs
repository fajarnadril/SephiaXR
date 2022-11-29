using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GantiScene : MonoBehaviour
{

    public void Ganti_Scene (string namaScene)
    {
        SceneManager.LoadScene(namaScene);
    }

    public void OpenWeb (string namaWeb)
    {
        Application.OpenURL(namaWeb);
    }
}
