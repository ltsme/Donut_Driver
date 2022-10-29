using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    [SerializeField] float destroyTime = 0.0f;
    [SerializeField] public Sprite[] carSprite;

    SpriteRenderer spriteRenderer;

    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Collision 발생");
    }

    private void OnTriggerEnter2D(Collider2D other) { // Collider 에서 isTrigger 속성 on
        if (other.tag == "Package" && !hasPackage) // Trigger가 발생한 개체의 태그가 Package인가?
        {
            Debug.Log("패키지 게또다제");
            spriteRenderer.sprite = carSprite[1];
            hasPackage = true;
            Destroy(other.gameObject, destroyTime);
        }

        if(other.tag == "Customer" && hasPackage){
            Debug.Log("배달 성공!");
             spriteRenderer.sprite = carSprite[0];
            hasPackage = false;
            Destroy(other.gameObject, destroyTime);
        }
    }
}
