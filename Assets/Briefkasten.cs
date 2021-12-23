using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Briefkasten : MonoBehaviour
{

    public GameObject tuer;
    public Animator tuerAn;


    

    private void OnTriggerEnter(Collider x)
    {
        if (x.gameObject.tag == "Brief")
        {
           // tuer.SetActive(false);
            tuerAn.SetBool("TuerDisappear", true);
        }
    }
}
