using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battery : MonoBehaviour
{
    [SerializeField]
    private int _charger;
    [SerializeField]
    int _chargerlimit;
    private static Battery _instance;

    public Text ChargerText;
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
   
    private void Start()
    {
        _charger = _chargerlimit;
    }
   
    public int GetUsage()
    {
        return _charger;
    }
    public void SetCharger(int usage)
    {
        _charger += usage;
        if (_charger >= _chargerlimit) 
        {
            _charger = _chargerlimit;
        }
        else if(_charger <= 0)
        {
            _charger = 0;          
        }
        ChargerText.text = "Charger: " + _charger.ToString();
    }
}
