using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TimeCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _TimerTxt = default;
    public float _timeLeft = 40;
    [SerializeField] private GameObject SceneChange;
   
    void Start()
    {
        Time.timeScale = 1;
    }

    
    void Update()
    {
        if (_timeLeft > 0)
        {
            _timeLeft -= Time.deltaTime;
        }
        else if (_timeLeft < 0)
        {

            Time.timeScale = 0;
        }
        UpdateTimer(_timeLeft, _TimerTxt);
        if (_timeLeft <= 0)
        {
            SceneChange.SetActive(true);
        }
    }
    private void UpdateTimer(float currentTimer, TextMeshProUGUI cronometer)
    {
        currentTimer += 1;
        float minutes = Mathf.FloorToInt(currentTimer / 60);
        float seconds = Mathf.FloorToInt(currentTimer % 60);
        cronometer.text = String.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
