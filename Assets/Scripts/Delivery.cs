using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    [SerializeField] float DestroyTime = 0.0f;

    private void Start() {
        Debug.Log(hasPackage);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Collision 발생");
    }

    private void OnTriggerEnter2D(Collider2D other) { // Collider 에서 isTrigger 속성 on
        if (other.tag == "Package" && !hasPackage) // Trigger가 발생한 개체의 태그가 Package인가?
        {
            Debug.Log("패키지 게또다제");
            hasPackage = true;
            Destroy(other.gameObject, DestroyTime);
        }

        if(other.tag == "Customer" && hasPackage){
            Debug.Log("배달 성공!");
            hasPackage = false;
            Destroy(other.gameObject, DestroyTime);
        }
    }
}
