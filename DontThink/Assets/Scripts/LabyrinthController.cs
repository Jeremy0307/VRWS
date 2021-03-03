using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabyrinthController : MonoBehaviour
{
    [SerializeField] private List<GameObject> _paterns = new List<GameObject>();

    [SerializeField] private GameObject _currentPatern = null;

    private void Start()
    {

        //Random Prefab
        _currentPatern = _paterns[Random.Range(0, _paterns.Count)];
        Debug.Log(_currentPatern);

        //Instantie le prefab
        Instantiate(_currentPatern, new Vector3(1, 1, -1), Quaternion.identity);

        //Desactive les autres paterns
        for (int i = 0; i < _paterns.Count; i++)
        {
            _paterns[i].SetActive(false);     
                
        }

    }

    private void Update()
    {

    }
}
