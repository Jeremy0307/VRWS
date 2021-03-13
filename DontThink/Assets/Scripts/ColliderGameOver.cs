using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderGameOver : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag.Equals("Water"))
        {
            Debug.Log("GameOver");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
