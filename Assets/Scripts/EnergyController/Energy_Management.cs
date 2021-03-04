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


    float time;
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
        if (time < Time.time)
        {
            time = Time.time + _consumRate;
            Battery.Instance.SetCharger(_chargerRate - _totalConsumption);
        }
       
    }


}
