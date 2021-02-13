using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalController : MonoBehaviour
{
    [SerializeField]
    float _timeToDestroy;
    void Start()
    {
        StartCoroutine(DestroySignal());
    }

    IEnumerator DestroySignal() 
    {
        yield return new WaitForSeconds(_timeToDestroy);
        Destroy(gameObject);
    }
}
