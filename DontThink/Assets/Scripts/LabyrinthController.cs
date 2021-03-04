using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabyrinthController : MonoBehaviour
{
    [SerializeField] private List<GameObject> _paterns = new List<GameObject>();

    [SerializeField] private GameObject _currentPatern = null;
    
    [SerializeField] private  Transform _radarTransform = null;

    private void Start()
    {
        Reset();
    }

    private void Reset()
    {
        //Random Prefab
        _currentPatern = _paterns[Random.Range(0, _paterns.Count)];
        Debug.Log(_currentPatern);

        //Instantie le prefab
        _currentPatern = Instantiate(_currentPatern, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        _currentPatern.transform.parent = _radarTransform.transform;

        //Desactive les autres paterns
        for (int i = 0; i < _paterns.Count; i++)
        {
            _paterns[i].SetActive(false);

        }
    }
}
