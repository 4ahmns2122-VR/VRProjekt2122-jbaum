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


   // private void OnTriggerEnter(Collider other)
   // {
   //     if (other.name == "") ;
   // }

    void Update()
    {
        t.text = a;
    }

    public void Eins()
    {
        a += "1";
    }

    public void Zwei()
    {
        a += "2";
    }

    public void Drei()
    {
        a += "3";
    }

    public void Vier()
    {
        a += "4";
    }
    public void Fuenf()
    {
        a += "5";
    }

    public void Sechs()
    {
        a += "6";
    }

    public void Sieben()
    {
        a += "7";
    }

    public void Acht()
    {
        a += "8";
    }

    public void Neun()
    {
        a += "9";
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
