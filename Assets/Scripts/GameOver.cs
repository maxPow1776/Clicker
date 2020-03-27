using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private Text _finalScoreText;
    [SerializeField] private GameObject spawner;
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _time;
    public bool _isGameWithTimer = false;

    public void Show()
    {
        _player.SetActive(false);
        spawner.SetActive(false);
        gameObject.SetActive(true);
    }

    public void SetScore(int score)
    {
        _finalScoreText.text = score.ToString();
    }

    public void OnRestartButtonClick()
    {
        _scoreText.text = "0";
        spawner.SetActive(true);
        _player.transform.position = new Vector3(0, 0, 0);
        _player.GetComponent<AutoMove>().acceleration = 1;
        _player.GetComponent<ConditionCollision>().score = 0;
        _player.SetActive(true);

        //Вы в прошлый раз говорили, что использование тэгов не очень хорошо. Но я пока не придумал, как сделать по-другому
        GameObject[] flowers = GameObject.FindGameObjectsWithTag("Flower");

        foreach(GameObject flower in flowers)
            Destroy(flower);
        gameObject.SetActive(false);
        if (_isGameWithTimer)
        {
            _time.SetActive(true);
            _time.GetComponent<TimerScript>()._timer = 3600;
        }
    }

    public void OnMainMenuButtonClick()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}
