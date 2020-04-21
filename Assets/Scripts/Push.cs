using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Push : MonoBehaviour
{
    [SerializeField] private KeyCode keyCode = KeyCode.Space;
    [SerializeField] private Vector2 Force;
    private Rigidbody2D rigidBody2D;


    private void OnValidate()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //if (Input.touchCount > 0)
        //{
        //    Touch touch = Input.GetTouch(0);
        //    if (touch.phase == TouchPhase.Began)
        //    {
        //        rigidBody2D.AddForce(Force, ForceMode2D.Impulse);
        //    }
        //}
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody2D.AddForce(Force, ForceMode2D.Impulse);
        }
    }   
}
