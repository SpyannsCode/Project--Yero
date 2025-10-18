using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public GameObject button;

    public void ChangeTint()
    {
        button.GetComponent<Image>().color = Color.white;
    }
}
