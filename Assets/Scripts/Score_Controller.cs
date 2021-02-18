using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class Score_Controller : MonoBehaviour
{
    private static Score_Controller _instance;

    public static Score_Controller Instance { get { return _instance; } }

    private int _totalScore;

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

    [SerializeField]
    private Text _scoreUi;

    public void ToScore(int points)
    {
        _totalScore += points;
        _scoreUi.text = "Score: " + _totalScore;
    }
}
