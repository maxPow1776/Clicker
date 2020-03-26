using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    [SerializeField] private Text _timeCount;
    [SerializeField] private Text _scoreCount;
    [SerializeField] private GameOver _gameOver;
    private int _timer = 3600;

    void Update()
    {
        _timer--;
        _timeCount.text = (_timer / 100).ToString();
        if(_timer == 0)
        {
            _gameOver.SetScore(int.Parse(_scoreCount.text));
            _gameOver.Show();
        }
    }
}
