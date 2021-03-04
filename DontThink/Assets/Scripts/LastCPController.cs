using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastCPController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
        Debug.Log("T'as gagné p'tit enculé !");
    }
}
