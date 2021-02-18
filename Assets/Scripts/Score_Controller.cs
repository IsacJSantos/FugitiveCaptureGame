using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class Score_Controller : MonoBehaviour
{
    private static Score_Controller _instance;

    public static Score_Controller Instance { get { return _instance; } }

    [SerializeField]
    private Text _scoreUi, _escapeText;
 
    private int _totalScore;
    [SerializeField]
    private int _totalEscapes;

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
  

    public void ToScore(int points)
    {
        _totalScore += points;
        _scoreUi.text = "Score: " + _totalScore;
    }

    public void EscapePoint() 
    {
        _totalEscapes++;
        _escapeText.text = "Escapes: " + _totalEscapes + "/10";
        if (_totalEscapes >= 10) 
        {
            _totalEscapes = 10;
            Time.timeScale = 0;
        }
    }
}
