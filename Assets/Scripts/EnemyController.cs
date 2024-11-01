using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyController : MonoBehaviour
{
    Rigidbody2D _compRigidbody2D;
    [SerializeField] float TimeFreeze;
    [SerializeField] TMP_Text textTimeFreeze;

    [SerializeField] Vector2 startPostition;

    private void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        transform.position = startPostition;
       
    }

    private void Update()
    {
        if(TimeFreeze > 0)
        {
            TimeFreeze -= Time.deltaTime;
            TimeFreeze -= Mathf.FloorToInt(TimeFreeze);
        }
       if(TimeFreeze < 0)
        {
            SetTextTimeFreeze(0);
        }
        
    }



    void SetTextTimeFreeze(float time)
    {
        textTimeFreeze.text = time.ToString();
    }




}
