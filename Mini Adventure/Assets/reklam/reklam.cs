using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reklam : MonoBehaviour
{
    public string githubs;
    public string itchs;
    public string discords;
    public string twitchs;
    public string youtubes;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void github()
    {
        Application.OpenURL(githubs);
    }
    public void itch()
    {
        Application.OpenURL(itchs);
    }
    public void discord()
    {
        Application.OpenURL(discords);
    }
    public void twitch()
    {
        Application.OpenURL(twitchs);
    }
    public void youtube()
    {
        Application.OpenURL(youtubes);
    }
}
