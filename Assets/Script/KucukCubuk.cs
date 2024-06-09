using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KucukCubuk : MonoBehaviour
{
    Rigidbody2D rb;
    public float hýz;
    public bool hareketkýsýtlýmý;
    public GameObject yönetici;
    public static bool oyunbitti;
    void Start()
    {
        yönetici = GameObject.FindGameObjectWithTag("Yonetýcý");
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (hareketkýsýtlýmý == false)
        {
          rb.MovePosition(rb.position + Vector2.up * hýz * Time.deltaTime);
        }
    }
     void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "DonenBuyukCember")
        {
            transform.SetParent(col.transform);
            hareketkýsýtlýmý = true;
        }
        if (col.gameObject.tag == "KucukCember")
        {
            oyunbitti = true;
            yönetici.GetComponent<OyunSonu>().OyunuBitir();
        }
    }
}
