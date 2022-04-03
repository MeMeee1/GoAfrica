using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickVaccine : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            PlayerManager.numberOfVaccines+=1;
        }
    }
}
