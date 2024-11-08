using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMusic : MonoBehaviour
{
    Button myButton;

    private void Awake()
    {
        myButton = GetComponent<Button>();
    }

    private void Start()
    {
        myButton.onClick.AddListener(Interactue);
    }

    void Interactue()
    {
        Time.timeScale = 0.0f;
        SingletonBasic.instance.Open();
    }
}
