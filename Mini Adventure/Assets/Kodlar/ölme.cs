using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ölme : MonoBehaviour
{
    public GameObject ölümEkranı;

    private void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "dusman")
        {
            ölümEkranı.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
