using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonUI : MonoBehaviour
{
   [SerializeField] Button myButton;
   [SerializeField] GameObject[] objectives;

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
        for(int i=0; i < objectives.Length; i++)
        {
            if (objectives[i].activeSelf)
            {
                Time.timeScale = 1.0f;
                objectives[i].gameObject.SetActive(false);
            }
            else
            {
                Time.timeScale = 0.0f;
                objectives[i].gameObject.SetActive(true);
            }
        }
        
    }
}
