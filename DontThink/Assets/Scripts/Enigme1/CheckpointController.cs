﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{

    [SerializeField] private LabyrinthController _labyrinthController = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Poignet"))
        {
            gameObject.SetActive(false);
            _labyrinthController.Checkpoint++;
        }
           
    }

    public void Reset()
    {
        gameObject.SetActive(true);
    }
}
