using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabyrinthController : MonoBehaviour
{
    [SerializeField] List<GameObject> _paterns = new List<GameObject>();

    private GameObject _currentPatern = null;

    private void Start()
    {
        _currentPatern = _paterns[Random.Range(0, _paterns.Count)];
        Debug.Log(_currentPatern);
    }

    private void Update()
    {
        
    }
}
