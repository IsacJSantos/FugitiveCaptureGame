using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JailController : MonoBehaviour
{
    [SerializeField]
    Transform[] _spawnPositions;

    [SerializeField]
    Transform[] _escapeAreas;

    [SerializeField]
    GameObject _fugitivePrefab;

    [SerializeField]
    float _spawnCooldown;

    float time;

    public void SpawnFugitive() 
    {
        if (time < Time.time)
        {
            int ramdomIndexPosition = Random.Range(0, _spawnPositions.Length);
            int randomIndexEscape = Random.Range(0, _escapeAreas.Length);

           GameObject fugitive = Instantiate(_fugitivePrefab, _spawnPositions[ramdomIndexPosition].position, Quaternion.identity);
           fugitive.GetComponent<FugitiveController>().target = _escapeAreas[randomIndexEscape].position;

            time = Time.time + _spawnCooldown;
        }
    }
}
