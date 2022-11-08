using UnityEngine;
using TMPro;
using System;

public class TimeCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _timerText = default;
    [SerializeField] private GameObject _sceneChange = default;
    [SerializeField] private float _timeLeft = 40;

    public static TimeCounter Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        Time.timeScale = 1;
    }

    public void IncreaseTime(float plus)
    {
        _timeLeft += plus;
    }

    void Update()
    {
        if (_timeLeft > 0)
        {
            _timeLeft -= Time.deltaTime;
        }

        UpdateTimer();

        if (_timeLeft <= 0)
        {
            Time.timeScale = 0;
            _sceneChange.SetActive(true);
        }
    }

    private void UpdateTimer()
    {
        float minutes = Mathf.FloorToInt(_timeLeft / 60);
        float seconds = Mathf.FloorToInt(_timeLeft % 60);
        _timerText.text = String.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
