using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class skor : MonoBehaviour
{
    public float zaman;
    public TMP_Text zaman_T;
    void Start()
    {
        zaman = 1;
        zaman_T.text = "" + zaman;
    }

    void Update()
    {
        zaman += Time.deltaTime;
        zaman_T.text = "" + (int)zaman;
        if(zaman <= 0)
        {
            zaman = 1;
            zaman_T.text = "" + (int)zaman;
        }
    }
}
