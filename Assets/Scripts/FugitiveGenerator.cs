using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FugitiveGenerator : MonoBehaviour
{
    [SerializeField]
    JailController[] Jails;
    
    [SerializeField]
    float _spawnCooldown;

    float time;

    // Update is called once per frame
    void Update()
    {
        if (time < Time.time)
        {
            Generate();
            time = Time.time + _spawnCooldown; 
        }
    }

    void Generate() 
    {
        int randomIndex = Random.Range(0, Jails.Length);

        Jails[randomIndex].SpawnFugitive();
    }
}
