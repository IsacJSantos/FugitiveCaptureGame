using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    [SerializeField]
    private int _charger;

    private static Battery _instance;

    public static Battery Instance { get { return _instance; } }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
        }
    }
    public int GetUsage() 
    {
        return _charger;
    }
    public void SetCharger(int usage) 
    {
        _charger += usage;
    }
}
