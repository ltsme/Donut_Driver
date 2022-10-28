using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // 카메라 위치 = 차 위치 + (0,0,-10)
    [SerializeField] GameObject thingToFollow;
    Vector3 CameraPosition = new Vector3 (0,0,-10);

    private void Start() {
        thingToFollow = GameObject.FindGameObjectWithTag("Player");
    }

    private void LateUpdate() {
        transform.position = thingToFollow.transform.position + CameraPosition;
    }
}
