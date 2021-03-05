using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsController : MonoBehaviour
{

    [SerializeField] private GameObject _key1, _key2 = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Zone"))
        {
            if(_key1 && _key2)
            {
                Debug.Log("C'est gagné !");
            }
        }
    }
}
