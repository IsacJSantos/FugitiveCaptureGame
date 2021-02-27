using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy_Management : MonoBehaviour
{
    [SerializeField]
    int _chargerRate;
    [SerializeField]
    float _consumRate;
    [SerializeField]
    int _totalConsumption;


    // Update is called once per frame
    void Update()
    {
        Consume();
    }

    public void SetConsumption(int usage) 
    {
        _totalConsumption += usage;
    }

    void Consume() 
    {
        // execute this once for ConsumRate 
        Battery.Instance.SetCharger(_totalConsumption - _chargerRate);
    }
}
