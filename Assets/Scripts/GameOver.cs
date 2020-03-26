using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private GameObject spawner;
    [SerializeField] private GameObject _player;

    public void Show()
    {
        Destroy(_player);
        spawner.SetActive(false);
        gameObject.SetActive(true);
    }

    public void SetScore(int score)
    {
        _scoreText.text = score.ToString();
    }

    public void OnRestartButtonClick()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    public void OnMainMenuButtonClick()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}
