using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZahlenquizTrigger : MonoBehaviour
{
    public Zahlenquiz zq;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Zahl")) {
            zq.Trigger(other.transform.gameObject.name);
            
        }


        if (other.CompareTag("pruefen"))
        {
            zq.Pruefen();
        }



        if (other.CompareTag("clear"))
        {
            zq.Clear();
        }
    }
}
