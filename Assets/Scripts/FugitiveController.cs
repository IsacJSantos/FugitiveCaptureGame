using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FugitiveController : MonoBehaviour
{
    [SerializeField]
    GameObject _signalPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_signalPrefab, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
