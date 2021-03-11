using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapZonesController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Tuyaux"))
        {
            other.transform.position = transform.position;
            other.transform.rotation = transform.rotation;
        }
    }
}
