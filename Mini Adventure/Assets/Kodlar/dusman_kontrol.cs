using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dusman_kontrol : MonoBehaviour
{
    public GameManager managerGame;

    [Header("Target")]
    private Transform karakterPos;
    private GameManager gm;

    [Header("Gameplay")]
    public float speed;
    private int can = 3;

    void Start()
    {
        karakterPos = GameObject.FindGameObjectWithTag("Karakter").GetComponent<Transform>();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(
            transform.position,
            karakterPos.position,
            speed * Time.deltaTime
            );
        if(can <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "mermi")
        {
            can--;
        }
    }
}
