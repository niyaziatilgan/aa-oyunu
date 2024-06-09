using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oyunSonuButton : MonoBehaviour
{
   public void OyunuTekrarBaslat()
    {
        SceneManager.LoadScene(1);
    }
    public void OyununMenusuneGit()
    {
        SceneManager.LoadScene(0);
    }
}
