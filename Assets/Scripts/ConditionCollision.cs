using UnityEngine;

public class ConditionCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Wall"))
        {
            if (transform.rotation.y == 0)
                transform.rotation = Quaternion.Euler(0, 180, 0);
            else
                transform.rotation = Quaternion.Euler(0, 0, 0);
        } else
        {
            Destroy(gameObject);
        }
    }
}
