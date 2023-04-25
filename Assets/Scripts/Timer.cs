using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public bool isAsnweringQuestion;

    public float fillFraction;

    public bool loadNextQuestion;

    float timerValue;

    [SerializeField] float timeAmount = 30f;

    [SerializeField] float timeToShowCorrectAnswer = 10f;


    void Update()
    {
        UpdateTimer();
    }

    public void Cancletimer()
    {
        timerValue = 0;
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;
        
        if(isAsnweringQuestion)
        {
            if(timerValue > 0)
            {
                fillFraction = timerValue / timeAmount;
            }
            else
            {
                isAsnweringQuestion = false;
                timerValue = timeToShowCorrectAnswer;
            }
        }
        else 
        {
            
            if(timerValue > 0)
            {
                fillFraction = timerValue / timeToShowCorrectAnswer;
            }
            else
            {
                isAsnweringQuestion = true;
                timerValue = timeAmount;
                loadNextQuestion = true;
            }           
        }
        
        Debug.Log(isAsnweringQuestion + ": " + timerValue + "= " + fillFraction);
    }
}
