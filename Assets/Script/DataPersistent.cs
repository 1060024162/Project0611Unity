using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistent : MonoBehaviour
{
    public int scoreValue;
    public ScoreUI scoreUI;
    public delegate void ScoreUpdate(int value);
    public static event ScoreUpdate OnUpdate;

    public void UpdateValue(int value)
    {
        scoreValue = Mathf.Clamp(scoreValue + value , 0 , 999999999);
        UpdateScoreUI();
        
    }
    
    public void InitializeValue(int value)
    {
        scoreValue = Mathf.Clamp(value, 0, 999999999);
    }

    void UpdateScoreUI() 
    {

        OnUpdate?.Invoke(scoreValue);

    }
}
