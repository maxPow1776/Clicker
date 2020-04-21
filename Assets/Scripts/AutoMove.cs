using UnityEngine;
using UnityEngine.UI;

public class AutoMove : MonoBehaviour
{
    [SerializeField] private Vector2 _speed = new Vector2(4f, 0f);
    public float Acceleration;

    private void FixedUpdate()
    {
        if (transform.rotation.y == 0)
            transform.position -= new Vector3(_speed.x, _speed.y, 0) * Time.deltaTime * Acceleration;
        else
            transform.position += new Vector3(_speed.x, _speed.y, 0) * Time.deltaTime * Acceleration;
        Acceleration *= 1.0005f;
    }
}
