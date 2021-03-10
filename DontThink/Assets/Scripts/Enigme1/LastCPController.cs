using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastCPController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Poignet"))
        {
            gameObject.SetActive(false);
            Debug.Log("T'as gagné p'tit enculé !");
        }
            
    }
}
