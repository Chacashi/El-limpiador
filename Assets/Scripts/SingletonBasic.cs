using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SingletonBasic : MonoBehaviour
{
    [SerializeField] GameObject objectiveGameObject;
    public static SingletonBasic instance;
    private void Awake()
    {
        if (instance == null && instance !=this)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    public void Open()
    {
        objectiveGameObject.SetActive(true);
    }
    
    public void Close()
    {
        objectiveGameObject.SetActive(false);
    }

}
