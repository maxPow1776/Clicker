using UnityEngine;
using UnityEngine.UI;

public class UIBehavior : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private GameOver _gameOverWindow;

    public void ChangeScore(int score)
    {
        _scoreText.text = score.ToString();
        _gameOverWindow.SetScore(score);
    }
}
