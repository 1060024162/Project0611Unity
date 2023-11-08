using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class ScoreUI : MonoBehaviour
{
    public TMP_Text textMeshProComponent; 

    void Start()
    {
        if (textMeshProComponent == null)
        {
            textMeshProComponent = GetComponent<TMP_Text>();
        }

        UpdateText(0);
    }

    public void UpdateText(int score)
    {
        if (textMeshProComponent != null)
        {
            // 更新TextMeshPro的文本
            textMeshProComponent.text =  score.ToString();
        }
        else
        {
            Debug.LogError("TMP_Text component not found!");
        }
    }

    private void OnEnable()
    {
        DataPersistent.OnUpdate += UpdateText;

    }

    private void OnDisable()
    {
        DataPersistent.OnUpdate -= UpdateText;
    }
}
