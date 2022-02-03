using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zahlenquiz : MonoBehaviour
{

    public string a;
    public int b;
    public Text t;
    public GameObject gruen;
    public GameObject rot;

    public void Trigger(string tag)
    {
        if(a.Length < 4) { a += tag; }
        
    }

    void Update()
    {
        t.text = a;
    }

    public void Pruefen()
    {
        if (int.Parse(a) == b)
        {
            gruen.SetActive(true);
            rot.SetActive(false);
        }
        else
        {
            rot.SetActive(true);
            gruen.SetActive(false);
        }
    }

    public void Clear()
    {
        a = "";
        rot.SetActive(false);
        gruen.SetActive(false);
    }
}
