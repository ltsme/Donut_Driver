using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]float steerspeed = 250f;
    [SerializeField]float movespeed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerspeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * movespeed * Time.deltaTime;
        
        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,moveAmount,0);
    }
}
