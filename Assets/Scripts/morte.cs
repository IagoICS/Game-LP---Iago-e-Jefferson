using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class morte : MonoBehaviour
{
    
void OnTriggerEnter2D(Collider2D other)
    {
        
                SceneManager.LoadScene("SampleScene");
                Debug.Log("batendo");
    }
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}