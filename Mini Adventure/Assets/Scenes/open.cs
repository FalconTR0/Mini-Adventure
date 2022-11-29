using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class open : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("Coutdown");
    }
    
    private IEnumerator Coutdown()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
}
