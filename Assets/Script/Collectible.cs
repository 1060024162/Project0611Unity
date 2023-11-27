using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour,ICollectible
{
    [SerializeField]
    public DataPersistent _data;
    [SerializeField]
    public int _value;
    public string collectibleType;
    public Quest quest;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hello");
        if (collision.gameObject.tag == "Player") 
        {
            Collect();
            Destroy(gameObject);
        
        }
    }


    public void Collect() {
        _data.UpdateValue(_value);
    }
    
}
