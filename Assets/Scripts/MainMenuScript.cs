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

    private void Start()
    {
        _bestScore.text = PlayerPrefs.GetInt("BestScore").ToString();
        _bestTimeLimitedScore.text = PlayerPrefs.GetInt("BestTimeLimitedScore").ToString();
    }

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
        _mainMenuAnimator.SetBool("isOpened", false);
        StartCoroutine(startGame());
        
    }

    IEnumerator startGame()
    {
        yield return new WaitForSeconds(1);
        gameObject.SetActive(false);
        _player.SetActive(true);
        _spawner.SetActive(true);
    }
}
