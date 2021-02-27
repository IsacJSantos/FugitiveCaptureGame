using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FugitiveController : MonoBehaviour
{

    public Vector3 target;

    [SerializeField]
    GameObject _signalPrefab;

    [SerializeField]
    float _speed;

    [SerializeField]
    int _score;

    bool _canCapture = true;
    bool _isMoving = true;
    void Start()
    {
        Instantiate(_signalPrefab, transform.position, Quaternion.identity);
        StartCoroutine(Movement());
    }


    IEnumerator Movement()
    {    
        while (Vector3.Distance(transform.position, target) > 0.001)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, _speed * Time.deltaTime);
            yield return null;
        }
       
        _canCapture = false;
        _isMoving = false;
        Escape();
    }
    public void Capture()
    {
        if (_canCapture)
        {
            Debug.Log("fugitive captured");
            Score_Controller.Instance.ToScore(_score);
            Destroy(gameObject);
        }

    }

    void Escape()
    {
        Score_Controller.Instance.EscapePoint();
        Destroy(gameObject);
    }
}
