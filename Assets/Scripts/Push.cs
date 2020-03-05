using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Push : MonoBehaviour
{
    public KeyCode keyCode = KeyCode.Space;

    public Vector2 Force;

    [HideInInspector]
    public Rigidbody2D rigidBody2D;


    private void OnValidate()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(keyCode))
        {
            rigidBody2D.AddForce(Force, ForceMode2D.Impulse);
        }
    }   
}
