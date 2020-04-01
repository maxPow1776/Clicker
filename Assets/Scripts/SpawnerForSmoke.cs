using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerForSmoke : MonoBehaviour
{
    [SerializeField] private GameObject[] prefabs;
    [SerializeField] private GameObject player;
    private String close = "close";
    private float[] leftCoordinates = {2.6f, 3.6f, 3.6f};
    private Vector3 right = new Vector3(9, 0, 0);
    private GameObject _smoke = null;

    public void Start()
    {
        ChangeWall();
    }

    public void ChangeWall()
    {
        if (_smoke != null)
            Destroy(_smoke);
        var random = UnityEngine.Random.value * 3;
        var prefabNumber = (int)random;
        if (prefabNumber == 3)
        {
            prefabNumber = 0;
        }
        GameObject prefab = prefabs[prefabNumber];
        if (player.transform.rotation.y == 0)
        {
            var position = new Vector3(-9 + leftCoordinates[prefabNumber], 0, 0);
            _smoke = Instantiate(prefab, position, Quaternion.identity);
        }
        else
            _smoke = Instantiate(prefab, right, Quaternion.identity);
    }
}
