using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetZoneController : MonoBehaviour
{
    //[SerializeField] private GameObject _handle = null;
    [SerializeField] private LabyrinthController _labyrinthController = null;

    private AudioSource _wrongSource = null;

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
        if(other.gameObject.tag == ("Poignet"))
        {
            _wrongSource.Play(0);
            _labyrinthController.Reset();
        }
       
    }
}
