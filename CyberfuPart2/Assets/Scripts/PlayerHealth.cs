using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxPlayerHealth = 10;
    public int currentPlayerHealth;
   
    void Start()
    {
        currentPlayerHealth = maxPlayerHealth;
    }
    
}
