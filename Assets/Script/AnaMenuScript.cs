using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnaMenuScript : MonoBehaviour
{
 public void OynaButonu()
    {
        SceneManager.LoadScene(1);
    }
public void OyunuBitir()
    {
        Debug.Log("Oyundan Çýkýþ Yapýldý");
    }
}
