using UnityEngine;
using UnityEngine.UI;

public class ConditionCollision : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Wall"))
        {
            if (transform.rotation.y == 0)
                transform.rotation = Quaternion.Euler(0, 180, 0);
            else
                transform.rotation = Quaternion.Euler(0, 0, 0);
            score += 1;
            scoreText.text = score.ToString();
        } else
        {
            Destroy(gameObject);
        }
    }
}
