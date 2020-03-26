using UnityEngine;
using UnityEngine.UI;

public class ConditionCollision : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private GameOver gameOver;
    private int score = 0;

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
            gameOver.SetScore(score);
            gameOver.Show();
        }
    }
}
