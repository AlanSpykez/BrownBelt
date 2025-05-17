using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{
    public bool hit;
    public LayerMask ahhh;
    void Update()
    {
        hit = Physics.Raycast(transform.position,transform.forward, 2f);
        Debug.DrawRay(transform.position, transform.forward * 2f, Color.green);
        if (hit) { 
            Debug.Log("for fahkey");

        } else {
            Debug.Log("for reeaal");
        }
    }
}
