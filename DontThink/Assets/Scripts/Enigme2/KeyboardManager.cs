using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardManager : MonoBehaviour
{

    [SerializeField] private string[] _keys = null;
    [SerializeField] private GameObject[] _paterns = null;

    private GameObject _currentPatern = null;
    private string _currentString = string.Empty;
    private int _keyIndex = 0;
    private string _updatedKey = string.Empty;

    [SerializeField] private int _testKey = 0;

    public string UpdatedKey
    {
        get => _updatedKey;
        set => _updatedKey = value;
    }

    void Start()
    {
        //_currentPatern = _paterns[Random.Range(0, _paterns.Length)];
        //_currentPatern.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        /*if(_currentPatern.name == "Patern1")
        {
            _keyIndex = 1;
        }

        else if (_currentPatern.name == "Patern2")
        {
            _keyIndex = 2;
        }

        else if (_currentPatern.name == "Patern3")
        {
            _keyIndex = 3;
        }*/

        if(_updatedKey.Length >= 5)
        {
            UpdatingWord();
        }
    }

    public void UpdatingWord()
    {
        if (_updatedKey == _keys[_testKey]) // à changer par _keyIndex après les tests
        {
            Debug.Log("We did it !");
            _updatedKey = string.Empty;
        }
    }

    private void Reset()
    {
        
    }
}
