using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnigme2 : MonoBehaviour
{
    [SerializeField] private Animator _anim = null;

    private void Awake()
    {
        _anim.enabled = false;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == ("Player"))
        {
            Debug.Log("Enter");
            _anim.enabled = true;
        }
    }
}
