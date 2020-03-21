using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private GameObject spawner;

    public void Show()
    {
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
}
