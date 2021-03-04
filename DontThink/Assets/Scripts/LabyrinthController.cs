using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabyrinthController : MonoBehaviour
{
    [SerializeField] private List<GameObject> _paterns = new List<GameObject>();

    [SerializeField] private GameObject _currentPatern = null;

    [SerializeField] private Transform _poignetSpawner = null;

    private static LabyrinthController _instance = null;

    public static LabyrinthController Instance
    {
        get
        {
            return _instance;
        }
        set
        {
            _instance = value;
        }
    }
    

    private void Start()
    {
        Reset();
    }

    public void Reset()
    {
        //Random Prefab
        _currentPatern = _paterns[Random.Range(0, _paterns.Count)];
        Debug.Log(_currentPatern);



        //Desactive les autres paterns
        for (int i = 0; i < _paterns.Count; i++)
        {
            _paterns[i].SetActive(false);

        }

        //Instantie le prefab
        _currentPatern.SetActive(true);
       
        //Le remet à sa place
        GameObject.FindGameObjectWithTag("PoignetSpawner").transform.position = transform.position;
    }
}
