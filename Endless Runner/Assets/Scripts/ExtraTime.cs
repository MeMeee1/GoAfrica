using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(70 * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<AudioManager>().PlaySound("Coin");
            PlayerManager.timer += 5;
            Destroy(gameObject);
        }
    }
}
