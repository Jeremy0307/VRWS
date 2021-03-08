using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour
{
    
        [SerializeField] private Animator _anim = null;

        private void Awake()
        {
            _anim.enabled = false;
        }

        public void OnClick()
        {
            
          _anim.enabled = true;
            
        }
}

