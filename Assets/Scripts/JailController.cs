using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JailController : MonoBehaviour
{
    [SerializeField]
    Transform[] _spawnPositions;

    [SerializeField]
    GameObject _fugitivePrefab;

    [SerializeField]
    float _spawnCooldown;

    float time;

    public void SpawnFugitive() 
    {
        if (time < Time.time)
        {
            int ramdomIndex = Random.Range(0, _spawnPositions.Length);

            Instantiate(_fugitivePrefab, _spawnPositions[ramdomIndex].position, Quaternion.identity);

            time = Time.time + _spawnCooldown;
        }
    }
}
