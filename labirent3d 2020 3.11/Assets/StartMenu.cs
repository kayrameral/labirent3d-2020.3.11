using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
public class StartMenu : MonoBehaviour
{
    public Button[] buttons;
    public void LoadLevel(int levelindex)
    {
        SceneManager.LoadScene(levelindex);
    }
}
