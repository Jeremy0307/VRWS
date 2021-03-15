using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapZonesController : MonoBehaviour
{
    [SerializeField] private ESnap _type = ESnap.none;

    [SerializeField] private PipeController _pipe = null;

    private bool _isInside = false;


    private void OnTriggerStay(Collider other)
    {

        if(other.CompareTag("Tuyaux"))
        {
            _pipe.Checking(other.gameObject, gameObject);
        }
    }
}
