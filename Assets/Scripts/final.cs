using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class final : MonoBehaviour
{
void OnTriggerEnter2D(Collider2D other)
    {
        
             Application.Quit();
                Debug.Log("batendo");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}