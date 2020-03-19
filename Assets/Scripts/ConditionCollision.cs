using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ConditionCollision : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Wall"))
        {
            if (transform.rotation.y == 0)
                transform.rotation = Quaternion.Euler(0, 180, 0);
            else
                transform.rotation = Quaternion.Euler(0, 0, 0);

        }
        else if (collision.gameObject.name.Contains("Flower"))
        {
            Destroy(collision.gameObject);
            score += 1;
            scoreText.text = score.ToString();
        }
        else
        {
            Destroy(gameObject);
            GlobalCount.score = scoreText.text;
            SceneManager.LoadScene("Respawn");
        }
    }
}
