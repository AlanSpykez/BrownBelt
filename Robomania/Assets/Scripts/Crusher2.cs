using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crusher2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
    void Start() {
        GetComponent<Rigidbody2D>().AddForce(Vector2.right * speed, ForceMode2D.Impulse); 
    }
}
