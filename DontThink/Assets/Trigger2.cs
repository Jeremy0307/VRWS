using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour
{
    
    [SerializeField] private Animator _anim = null;
    [SerializeField] private Material[] _renderer = null;
    [SerializeField] private MeshRenderer _paper = null;

    private int _rand = 0;

    private void Awake()
    {
        _anim.enabled = false;
        _rand = Random.Range(0, _renderer.Length);
    }

    public void OnClick()
    {
            
        _anim.enabled = true;
        _paper.material = _renderer[_rand];
            
    }
}

