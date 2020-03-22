using UnityEngine;
using UnityEngine.UI;

public class AutoMove : MonoBehaviour
{
    [SerializeField] private Vector2 speed = new Vector2(4f, 0f);
    [SerializeField] private float acceleration;

    private void FixedUpdate()
    {
        if (transform.rotation.y == 0)
            transform.position -= new Vector3(speed.x, speed.y, 0) * Time.deltaTime * acceleration;
        else
            transform.position += new Vector3(speed.x, speed.y, 0) * Time.deltaTime * acceleration;
        acceleration *= 1.0005f;
    }
}
