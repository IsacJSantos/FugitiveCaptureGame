using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FugitiveController : MonoBehaviour
{
    [SerializeField]
    GameObject _signalPrefab;
  
    void Start()
    {
        Instantiate(_signalPrefab, transform.position, Quaternion.identity);
    }

   
    public void Capture()
    {
        Debug.Log("fugitive captured");
        Destroy(gameObject);
    }
}
