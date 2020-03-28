﻿using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField] GameObject _player;
    [SerializeField] GameObject _spawner;
    [SerializeField] GameObject _time;
    [SerializeField] GameObject _gameOver;

    public void OnGameWithATimeLimitButtonClick()
    {
        OnPlayButtonClick();
        _time.SetActive(true);
        _gameOver.GetComponent<GameOver>()._isGameWithTimer = true;
        _player.GetComponent<AutoMove>().acceleration = 2.5f;
        _spawner.GetComponent<Spawner>().interval = 0.5f;
    }

    public void OnPlayButtonClick()
    {
        gameObject.SetActive(false);
        _player.SetActive(true);
        _spawner.SetActive(true);
    }
}
