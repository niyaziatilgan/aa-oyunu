using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraanimasyon : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void Update()
    {
        if (KucukCubuk.oyunbitti == true)
        {
            anim.SetBool("OyunBitti", true);
        }
    }
}
