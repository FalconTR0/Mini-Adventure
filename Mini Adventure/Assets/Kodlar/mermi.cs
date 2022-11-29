using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mermi : MonoBehaviour
{
    bool isMute;
    private Vector2 target;
    public AudioSource seskontrol;
    public AudioClip aBullet;

    public float speed;

    void Start()
    {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(
           transform.position,
           target,
           speed * Time.deltaTime
            );
        Destroy(gameObject, 1f);
        seskontrol.PlayOneShot(aBullet);
    }
}
