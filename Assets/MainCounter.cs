using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainCounter : MonoBehaviour
{
    [SerializeField] private Text CounterText;
    private int count = 0;
    
    public void IncCount(int value)
    {
        count += value;
        CounterText.text = "Score : " + count;
    }
}
