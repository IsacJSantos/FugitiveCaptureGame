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
    [SerializeField]
    GameObject _lampLightObj;

    public void OnOff(bool value) 
    {
        _on = value;
        _lampLightObj.SetActive(_on);
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
