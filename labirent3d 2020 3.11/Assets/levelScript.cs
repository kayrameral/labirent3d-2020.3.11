using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class levelScript : MonoBehaviour
{
   public void bolum_ac(string bolum_ismi)
    {
       
        Application.LoadLevel(bolum_ismi);
    }
}