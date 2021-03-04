using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetZoneController : MonoBehaviour
{
    //[SerializeField] private GameObject _handle = null;
    [SerializeField] private LabyrinthController _labyrinthController = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        _labyrinthController.Reset();
    }
}
