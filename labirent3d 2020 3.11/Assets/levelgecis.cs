
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelgecis : MonoBehaviour
{
    int levelsUnlocked=1;
    public Button[] buttons;
    void Start()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
        buttons[0].interactable = true;
    }
        void cby()
        {
            if (SceneManager.GetActiveScene().buildIndex==0)
                buttons[SceneManager.GetActiveScene().buildIndex].interactable = true;
        
            if (SceneManager.GetActiveScene().buildIndex == 1)
                buttons[SceneManager.GetActiveScene().buildIndex + 3].interactable = true;
        print(SceneManager.GetActiveScene().buildIndex);
    }  
}