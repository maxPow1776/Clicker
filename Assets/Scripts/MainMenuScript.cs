using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _spawner;
    [SerializeField] private GameObject _time;
    [SerializeField] private GameObject _gameOver;
    [SerializeField] private Animator _mainMenuAnimator;
    [SerializeField] private Text _bestScore;
    [SerializeField] private Text _bestTimeLimitedScore;
    [SerializeField] private GameObject _spawnerForSmoke;
    private String _theBestTimeLimitedScore = "BestTimeLimitedScore";
    private String _theBestScore = "BestScore";
    private String _animatorCheck = "isOpened";

    private void Start()
    {
        _bestScore.text = PlayerPrefs.GetInt(_theBestScore).ToString();
        _bestTimeLimitedScore.text = PlayerPrefs.GetInt(_theBestTimeLimitedScore).ToString();
    }

    public void OnGameWithATimeLimitButtonClick()
    {
        _mainMenuAnimator.SetBool(_animatorCheck, false);
        StartCoroutine(startGame());
        _time.SetActive(true);
        if(_gameOver.GetComponent<GameOver>() != null)
            _gameOver.GetComponent<GameOver>()._isGameWithTimer = true;
        if(_player.GetComponent<AutoMove>() != null)
            _player.GetComponent<AutoMove>().Acceleration = 2.5f;
        if(_spawner.GetComponent<Spawner>() != null)
            _spawner.GetComponent<Spawner>().interval = 0.5f;
    }

    public void OnPlayButtonClick()
    {
        _mainMenuAnimator.SetBool(_animatorCheck, false);
        StartCoroutine(startGame());
        _spawnerForSmoke.SetActive(true);
        
    }

    IEnumerator startGame()
    {
        yield return new WaitForSeconds(1);
        gameObject.SetActive(false);
        _player.SetActive(true);
        _spawner.SetActive(true);
    }
}
