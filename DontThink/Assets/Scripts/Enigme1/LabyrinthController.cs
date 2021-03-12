using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabyrinthController : MonoBehaviour
{
    [SerializeField] private List<GameObject> _paterns = new List<GameObject>();

    [SerializeField] private GameObject _currentPatern = null;

    [SerializeField] private Transform _poignet = null;

    [SerializeField] private Transform _startingPoint = null;

    [SerializeField] private GameObject[] _lastCP = null;

    [SerializeField] private CheckpointController[] _checkpoints = null;

    [SerializeField] private GameObject[] _patternAnimation = null;

    [SerializeField] private GameObject[] _patternCpAnimation = null;


    private int _checkpoint = 0;

    public int Checkpoint
    {
        get => _checkpoint;
        set => _checkpoint = value;
    }
    
    private void Start()
    {
        ChooseNewPatern();
    }

    private void Update()
    {
        if(_checkpoint == 3)
        {
            if (_paterns[0])
            {
                _patternAnimation[0].SetActive(false);
                _lastCP[0].SetActive(true);
                _patternCpAnimation[0].SetActive(true);
            }

            if(_paterns[1])
            {
                _patternAnimation[1].SetActive(false);
                _lastCP[1].SetActive(true);
                _patternCpAnimation[1].SetActive(true);
            }
        }
    }

    public void Reset()
    {
        //Le remet à sa place
        //_poignet.gameObject.transform.position = GameObject.FindGameObjectWithTag("PoignetSpawner").transform.position;
        _poignet.transform.position = _startingPoint.transform.position;

        if (_checkpoint > 0)
        {

            for (int i = 0; i < _paterns.Count; i++)
            {
                _lastCP[i].SetActive(false);
            }
        }

        for (int i = 0; i < _paterns.Count; i++)
        {
            _paterns[0].SetActive(true);
            _paterns[1].SetActive(true);
        }

        ResetCP();

        ChooseNewPatern();
       
    }

    public void ChooseNewPatern()
    {
        //Random Prefab
        _currentPatern = _paterns[Random.Range(0, _paterns.Count)];
        Debug.Log(_currentPatern);


        for (int i = 0; i < _patternAnimation.Length; i++)
        {
            _patternAnimation[i].SetActive(false);
        }

        for (int i = 0; i < _patternCpAnimation.Length; i++)
        {
            _patternCpAnimation[i].SetActive(false);
        }

        //Desactive les autres paterns
        for (int i = 0; i < _paterns.Count; i++)
        {
            _paterns[i].SetActive(false);

        }

        //Instantie le prefab
        _currentPatern.SetActive(true);

        if (_currentPatern == _paterns[0])
        {
            _patternAnimation[0].SetActive(true);
        }
        if (_currentPatern == _paterns[1])
        {
            _patternAnimation[1].SetActive(true);
        }
    }

    public void ResetCP()
    {
        _checkpoint = 0;
        for (int i = 0; i < _checkpoints.Length; i++)
        {
            _checkpoints[i].Reset();
        }
        
    }
}

