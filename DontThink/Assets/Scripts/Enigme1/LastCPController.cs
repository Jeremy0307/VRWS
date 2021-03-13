using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastCPController : MonoBehaviour
{

    [SerializeField] private Light _lightSuccess = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Poignet"))
        {
            gameObject.SetActive(false);
            Debug.Log("T'as gagné p'tit enculé !");

            //Play Sound



            //Change la couleur de la light
            _lightSuccess.color = Color.green;

        }

    }
}
