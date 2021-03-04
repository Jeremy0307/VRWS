using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoignetManager : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ResetTrigger"))
        {
            Debug.Log("Collision with TriggerReset");
            LabyrinthController.Instance.Reset();
        }
    }
}
