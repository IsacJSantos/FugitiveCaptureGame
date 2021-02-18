using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ui_Controller : MonoBehaviour
{
    [SerializeField]
    private Text _scoreUi;

    public void ToScore(int points)
    {
        _scoreUi.text = "Score: " + points;
    }
}
