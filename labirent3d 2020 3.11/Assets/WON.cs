using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WON : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Sphere")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
           
        }
    }
}