using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public class GameOver : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private Text _finalScoreText;
    [SerializeField] private GameObject spawner;
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _time;
    [SerializeField] Animator _gameOverAnimator;
    [SerializeField] private Text _bestScore;
    public bool _isGameWithTimer = false;
    private String _bestTimeLimitedScore = "BestTimeLimitedScore";
    private String _theBestScore = "BestScore";
    private String _animatorCheck = "isOpened";

    public void Show()
    {
        _player.SetActive(false);
        spawner.SetActive(false);
        gameObject.SetActive(true);

        if (_isGameWithTimer)
            _bestScore.text = PlayerPrefs.GetInt(_bestTimeLimitedScore).ToString();
        else
            _bestScore.text = PlayerPrefs.GetInt(_theBestScore).ToString();
        if (Convert.ToInt32(_finalScoreText.text) > Convert.ToInt32(_bestScore.text))
        {
            _bestScore.text = _finalScoreText.text;
            if (_isGameWithTimer)
                PlayerPrefs.SetInt(_bestTimeLimitedScore, Convert.ToInt32(_bestScore.text));
            else
                PlayerPrefs.SetInt(_theBestScore, Convert.ToInt32(_bestScore.text));
        }
    }

    public void SetScore(int score)
    {
        _finalScoreText.text = score.ToString();
    }

    public void OnRestartButtonClick()
    {
        _gameOverAnimator.SetBool(_animatorCheck, false);
        StartCoroutine(RestartButtonClick());
    }

    public void OnMainMenuButtonClick()
    {
        _gameOverAnimator.SetBool(_animatorCheck, false);
        StartCoroutine(MainMenutButtonClick());
    }

    IEnumerator RestartButtonClick()
    {
        yield return new WaitForSeconds(1);
        _scoreText.text = "0";
        spawner.SetActive(true);
        _player.transform.position = new Vector3(0, 0, 0);
        _player.GetComponent<ConditionCollision>().score = 0;
        _player.SetActive(true);

        if (spawner.GetComponent<Spawner>().Flowers != null)
        {
            foreach (GameObject flower in spawner.GetComponent<Spawner>().Flowers)
            {
                if (flower != null)
                    Destroy(flower);
            }
        }
            
        gameObject.SetActive(false);
        if (_isGameWithTimer)
        {
            _time.SetActive(true);
            _time.GetComponent<TimerScript>()._timer = 3000;
            _player.GetComponent<AutoMove>().Acceleration = 2.5f;
        }
        else
        {
            if(_player.GetComponent<AutoMove>() != null)
                _player.GetComponent<AutoMove>().Acceleration = 1;
        }
    }

    IEnumerator MainMenutButtonClick()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}
