using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Quest : MonoBehaviour
{
    public Objectif[] objectifs;
    public bool isStarted;
    public bool isFinished;

    public void StartQuest()
    {
        isStarted = true;
        isFinished = false;
    }

    public void QuestFinished() 
    { 
        isStarted=false;
        isFinished = true;
    }


    public void CheckQuestObjectif()
    { 
        for (int i = 0; i < objectifs.Length; i++) 
        {
            if (!objectifs[i].isFinished) 
            {
                return;
            }
        }
        QuestFinished();
    }

    public void UpdateObjectif(Collectible collectible) 
    { 
        for(int i = 0;i < objectifs.Length;i++) 
        {
            if (collectible.collectibleType.Equals(objectifs[i].collectibleType))
            {
                objectifs[i].actuelValue += collectible._value;
                CheckObjectif(i);
            }
        }
    }

    public void CheckObjectif(int i)
    {
        if (objectifs[i].actuelValue >= objectifs[i].maxValue)
        {
            objectifs[i].isFinished = true;
            CheckQuestObjectif();
        }
    }
}