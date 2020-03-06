using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float interval;

    public GameObject from;
    public GameObject to;

    private float timer;

    private void FixedUpdate()
    {
        timer -= Time.fixedDeltaTime;

        if (timer > 0)
            return;

        timer += interval;
        var position = new Vector2(Random.Range(from.transform.position.x,
            to.transform.position.x), Random.Range(from.transform.position.y,
            to.transform.position.y));
        Instantiate(prefab, position, Quaternion.identity);
    }
}
