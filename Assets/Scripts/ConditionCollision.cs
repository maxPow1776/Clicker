using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ConditionCollision : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    [SerializeField] private GameOver gameOver;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<BoxCollider2D>())
        {
            if (transform.rotation.y == 0)
                transform.rotation = Quaternion.Euler(0, 180, 0);
            else
                transform.rotation = Quaternion.Euler(0, 0, 0);

        }
        else if (collision.gameObject.GetComponent<CircleCollider2D>())
        {
            Destroy(collision.gameObject);
            score += 1;
            scoreText.text = score.ToString();
        }
        else
        {
            Destroy(gameObject);
            //GlobalCount.score = scoreText.text;
            //SceneManager.LoadScene("Respawn");
            gameOver.SetScore(score);
            gameOver.Show();
        }
    }
}
