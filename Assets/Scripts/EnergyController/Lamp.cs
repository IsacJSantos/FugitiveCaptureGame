using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    [SerializeField]
    bool _on;
    [SerializeField]
    int _energyCost;
    [SerializeField]
    Energy_Management _energyManag;

    GameObject _lampLightObj;

    private void Start()
    {
        _lampLightObj = GetComponentInChildren<GameObject>(); 
    }
    public void OnOff(bool value) 
    {
        _on = value;

        if (_on)
        {
            _energyManag.SetConsumption(_energyCost);
        }
        else
        {
            _energyManag.SetConsumption(_energyCost * -1);
        }
    }
}
