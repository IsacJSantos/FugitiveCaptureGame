using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class Score_Controller : MonoBehaviour
{
    private static Score_Controller _instance;

    public static Score_Controller Instance { get { return _instance; } }
    [SerializeField]
    private int MaxEscapes;
    [SerializeField]
    private Text _scoreUi, _escapeText;



    private int _totalScore;
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

    private void Start()
    {
        _escapeText.text = "Escapes: " + _totalEscapes + "/" + MaxEscapes;
    }

    public void ToScore(int points)
    {
        _totalScore += points;
        _scoreUi.text = "Score: " + _totalScore;
    }

    public void EscapePoint() 
    {
        _totalEscapes++;
        _escapeText.text = "Escapes: " + _totalEscapes + "/"+ MaxEscapes;
        if (_totalEscapes >= MaxEscapes) 
        {
            _totalEscapes = MaxEscapes;
           // Time.timeScale = 0;
        }
    }
}
