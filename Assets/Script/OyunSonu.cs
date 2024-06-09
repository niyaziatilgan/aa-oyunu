using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyunSonu : MonoBehaviour
{
    
    public GameObject DonenBuyukCember;
    public GameObject SpawnLokasyonu;

   
    public void OyunuBitir()
    {
      DonenBuyukCember.GetComponent<DonenBuyukCember>().enabled = false;
      SpawnLokasyonu.GetComponent<KucukCubukSpawner>().enabled = false;

        SceneManager.LoadScene(2);
    }
}
