using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    [SerializeField] private float _time;
    private bool _timerOn = false;

    public TextMeshProUGUI _timeText;

    void Start()
    {
        _timerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (_timerOn)
        {
            if (_time > 0)
            {
                _time -= Time.deltaTime;
                UpdateTimer(_time);
            }
        }
        else
        {
            Debug.Log("Time's up.");
            _time = 0;
            _timerOn = false;
        }
    }

    void UpdateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        _timeText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

    public void LoseTime(float timeLost)
    {
        _time -= timeLost;
        Debug.Log("Time lost: " + timeLost);
    }

    public void GainTime(float timeWon)
    {
        _time += timeWon;
        Debug.Log("Time added: " + timeWon);
    }
}
