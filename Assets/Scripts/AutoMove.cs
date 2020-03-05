using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public Vector2 speed = new Vector2(4f, 0f);

    private void FixedUpdate()
    {
        if (transform.rotation.y == 0)
            transform.position -= new Vector3(speed.x, speed.y, 0) * Time.deltaTime;
        else
            transform.position += new Vector3(speed.x, speed.y, 0) * Time.deltaTime;
    }
}
