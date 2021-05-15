using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField] private int boxValue;
    [SerializeField] private MainCounter _mainCounter;
    
    [SerializeField] private Text CounterText;

    private int count = 0;

    private void Start()
    {
        count = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        _mainCounter.IncCount(boxValue);
        count ++;
        
        CounterText.text = count + " balls";
    }
}
