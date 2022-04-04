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
   
    private void OnTriggerExit(Collider other)
    {
        if(other.tag=="Player")
        {
            PlayerManager.numberOfVaccines++;
            Debug.Log("It worked");
            Destroy(gameObject);
        }
    }
}

