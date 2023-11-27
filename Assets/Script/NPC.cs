using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public Dialogue[] sentences;
    public Quest quest;
    public int startSentence;
    public int endSentence;
    public int intermadiateSentence;


    public void InteractionNPC()
    {
        if (quest.isStarted)
        { 
            
        }else if (quest.isFinished) 
        { 
            
        }
    
    }

    public bool StartDialogue(int startNumber)
    { 
        
        return true;
    }
}
