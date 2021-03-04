using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sector : MonoBehaviour
{
    //Jail list

    [SerializeField]
    Lamp[] _lamps;
    [SerializeField]
    GameObject _colliders;

    public void GenerateFugitive() 
    {
    }

    public void lampOnOff(bool value) 
    {
        StartCoroutine(TurnLampsOnOff(value));
        _colliders.SetActive(!value);
    }
    IEnumerator TurnLampsOnOff(bool value) 
    {
        for (int i = 0; i < _lamps.Length; i++)
        {
            _lamps[i].OnOff(value);
            yield return null;
        }
    }
}
