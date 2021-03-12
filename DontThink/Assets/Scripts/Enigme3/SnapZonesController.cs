using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapZonesController : MonoBehaviour
{
    [SerializeField] private ESnap _type = ESnap.none;

    [SerializeField] private PipeController _pipe = null;


    private void OnTriggerEnter(Collider other)
    {

        if(other.CompareTag("Tuyaux"))
        {
            if(_type == ESnap.snap1 && _pipe.Type == ETuyauEnum.tuyau4)
            {
                Debug.Log("Collision");
                other.gameObject.SetActive(false);
                gameObject.GetComponent<MeshRenderer>().enabled = true;
            }

            if (_type == ESnap.snap2 && _pipe.Type == ETuyauEnum.tuyau1)
            {
                Debug.Log("Collision");
                other.gameObject.SetActive(false);
                gameObject.GetComponent<MeshRenderer>().enabled = true;
            }

            if (_type == ESnap.snap3 && _pipe.Type == ETuyauEnum.tuyau5)
            {
                Debug.Log("Collision");
                other.gameObject.SetActive(false);
                gameObject.GetComponent<MeshRenderer>().enabled = true;
            }

            if (_type == ESnap.snap4 && _pipe.Type == ETuyauEnum.tuyau3)
            {
                Debug.Log("Collision");
                other.gameObject.SetActive(false);
                gameObject.GetComponent<MeshRenderer>().enabled = true;
            }

            if (_type == ESnap.snap5 && _pipe.Type == ETuyauEnum.tuyau2)
            {
                Debug.Log("Collision");
                other.gameObject.SetActive(false);
                gameObject.GetComponent<MeshRenderer>().enabled = true;
            }
        }
    }
}
