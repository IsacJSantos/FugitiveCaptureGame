using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controll_Button : MonoBehaviour
{
    [SerializeField]
    Sector _sector;
    [SerializeField]
    bool _on;
    public void Active() 
    {
        _on = !_on;
        _sector.lampOnOff(_on);
    }
}
