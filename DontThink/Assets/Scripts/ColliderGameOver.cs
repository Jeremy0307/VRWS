using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderGameOver : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag.Equals("Water"))
        {
            Debug.Log("GameOver");
        }
    }
}
