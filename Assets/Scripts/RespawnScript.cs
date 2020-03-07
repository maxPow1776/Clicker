using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RespawnScript : MonoBehaviour
{
    public Text totalScore;

    public void OnRestartButtonClick()
    {
        SceneManager.LoadScene("SampleScene");
    }

    private void Start()
    {
        totalScore.text = GlobalCount.score;
    }
}
