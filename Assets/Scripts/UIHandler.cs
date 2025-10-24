using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIHandler : MonoBehaviour
{
    /// <summary>
    /// public GameObject button;
    /// </summary>

    public int Score = 0;
    private string aux;
    public TMP_Text text;

    private void Update()
    {
        aux = Score.ToString();
        text.text = aux;
    }
   /* public void ChangeTint()
    {
        button.GetComponent<Image>().color = Color.white;
    }*/
}
