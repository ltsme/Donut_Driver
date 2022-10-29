using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]float steerspeed = 150f;
    [SerializeField]float movespeed = 10.0f;
    [SerializeField]float boostSpeed = 20.0f;
    [SerializeField]float slowSpeed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerspeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * movespeed * Time.deltaTime;
        
        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,moveAmount,0);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Boost")
        {
            movespeed = boostSpeed;
        }
        if (other.tag == "Slow")
        {
            movespeed = 10.0f;
        }
    }
}
