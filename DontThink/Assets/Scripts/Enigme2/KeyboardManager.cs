using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardManager : MonoBehaviour
{

    [SerializeField] private string[] _keys = null;
    [SerializeField] private Trigger2 _trigger = null;

    [SerializeField] private Light _lightSuccess = null;

    private GameObject _currentPatern = null;
    private string _currentString = string.Empty;
    private string _updatedKey = string.Empty;

    [SerializeField] private AudioSource _wrongSource = null;
    [SerializeField] private AudioSource _successSource = null;

    [SerializeField] private Light[] _lights = null;

    

    public string UpdatedKey
    {
        get => _updatedKey;
        set => _updatedKey = value;
    }

    void Start()
    {
        _currentString = _keys[_trigger.Index];
        _updatedKey = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        if (_trigger.Index == 0)
        {
            if (_updatedKey.Length == 1 && _updatedKey != "O")
            {
                Debug.Log("WRONG !");
                _wrongSource.Play(0);
                Reset();
            }

            if (_updatedKey.Length == 2 && _updatedKey != "OV")
            {
                Debug.Log("WRONG !");
                _wrongSource.Play(0);
                Reset();
            }

            if (_updatedKey.Length == 3 && _updatedKey != "OVW")
            {
                Debug.Log("WRONG !");
                _wrongSource.Play(0);
                Reset();
            }

            if (_updatedKey.Length == 4 && _updatedKey != "OVW6")
            {
                Debug.Log("WRONG !");
                _wrongSource.Play(0);
                Reset();
            }

            if (_updatedKey.Length == 5 && _updatedKey != "OVW6A")
            {
                Debug.Log("WRONG !");
                _wrongSource.Play(0);
                Reset();
            }
        }

        if (_trigger.Index == 1)
        {
            if (_updatedKey.Length == 1 && _updatedKey != "D")
            {
                Debug.Log("WRONG !");
                _wrongSource.Play(0);
                Reset();
            }

            if (_updatedKey.Length == 2 && _updatedKey != "DR")
            {
                Debug.Log("WRONG !");
                _wrongSource.Play(0);
                Reset();
            }

            if (_updatedKey.Length == 3 && _updatedKey != "DRS")
            {
                Debug.Log("WRONG !");
                _wrongSource.Play(0);
                Reset();
            }

            if (_updatedKey.Length == 4 && _updatedKey != "DRSM")
            {
                Debug.Log("WRONG !");
                _wrongSource.Play(0);
                Reset();
            }

            if (_updatedKey.Length == 5 && _updatedKey != "DRSM2")
            {
                Debug.Log("WRONG !");
                _wrongSource.Play(0);
                Reset();
            }
        }

        if (_trigger.Index == 2)
        {
            if (_updatedKey.Length == 1 && _updatedKey != "Y")
            {
                Debug.Log("WRONG !");
                _wrongSource.Play(0);
                Reset();
            }

            if (_updatedKey.Length == 2 && _updatedKey != "Y7")
            {
                Debug.Log("WRONG !");
                _wrongSource.Play(0);
                Reset();
            }

            if (_updatedKey.Length == 3 && _updatedKey != "Y7H")
            {
                Debug.Log("WRONG !");
                _wrongSource.Play(0);
                Reset();
            }

            if (_updatedKey.Length == 4 && _updatedKey != "Y7HL")
            {
                Debug.Log("WRONG !");
                _wrongSource.Play(0);
                Reset();
            }

            if (_updatedKey.Length == 5 && _updatedKey != "Y7HL1")
            {
                Debug.Log("WRONG !");
                _wrongSource.Play(0);
                Reset();
            }
        }

        if (_trigger.Index == 0)
        {
            if (_updatedKey.Length == 1 && _updatedKey == "O")
            {
                _lights[0].color = Color.green;
            }

            if (_updatedKey.Length == 2 && _updatedKey == "OV")
            {
                _lights[1].color = Color.green;
            }

            if (_updatedKey.Length == 3 && _updatedKey == "OVW")
            {
                _lights[2].color = Color.green;
            }

            if (_updatedKey.Length == 4 && _updatedKey == "OVW6")
            {
                _lights[3].color = Color.green;
            }

            if (_updatedKey.Length == 5 && _updatedKey == "OVW6A")
            {
                //_lights[4].color = Color.green;
            }
        }

        if (_trigger.Index == 1)
        {
            if (_updatedKey.Length == 1 && _updatedKey == "D")
            {
                _lights[0].color = Color.green;
            }

            if (_updatedKey.Length == 2 && _updatedKey == "DR")
            {
                _lights[1].color = Color.green;
            }

            if (_updatedKey.Length == 3 && _updatedKey == "DRS")
            {
                _lights[2].color = Color.green;
            }

            if (_updatedKey.Length == 4 && _updatedKey == "DRSM")
            {
                _lights[3].color = Color.green;
            }

            if (_updatedKey.Length == 5 && _updatedKey == "DRSM2")
            {
                //_lights[4].color = Color.green;
            }
        }

        if (_trigger.Index == 2)
        {
            if (_updatedKey.Length == 1 && _updatedKey == "Y")
            {
                _lights[0].color = Color.green;
            }

            if (_updatedKey.Length == 2 && _updatedKey == "Y7")
            {
                _lights[1].color = Color.green;
            }

            if (_updatedKey.Length == 3 && _updatedKey == "Y7H")
            {
                _lights[2].color = Color.green;
            }

            if (_updatedKey.Length == 4 && _updatedKey == "Y7HL")
            {
                _lights[3].color = Color.green;
            }

            if (_updatedKey.Length == 5 && _updatedKey == "Y7HL1")
            {
                //_lights[4].color = Color.green; ;
            }
        }

        if (_updatedKey.Length >= 5)
        {
            UpdatingWord();
        }
    }

    public void UpdatingWord()
    {
        if (_updatedKey == _currentString)
        {
            //Play Sound
            _successSource.Play(0);

            //Change la couleur de la light

            _lightSuccess.color = Color.green;

            Debug.Log("We did it !");
            _updatedKey = string.Empty;
        }
    }

    private void Reset()
    {
        _updatedKey = string.Empty;
        _trigger.Reset();
        _currentString = _keys[_trigger.Index];

        for (int i = 0; i < _lights.Length; i++)
        {
            _lights[i].color = Color.red;
        }
    }
}
