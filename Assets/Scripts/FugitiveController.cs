using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FugitiveController : MonoBehaviour
{
    [SerializeField]
    GameObject _signalPrefab;
    [SerializeField]
    int _score;
    void Start()
    {
        Instantiate(_signalPrefab, transform.position, Quaternion.identity);
    }

   
    public void Capture()
    {
        Debug.Log("fugitive captured");
        Score_Controller.Instance.ToScore(_score);
        Destroy(gameObject);
    }
}
