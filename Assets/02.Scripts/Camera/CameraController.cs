using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform target;

    private Vector3 offset = new Vector3(0, 0, -10); // 카메라와 플레이어 사이의 거리
    private Vector3 currentVelocity = Vector3.zero;

    private float smoothTime = 0.15f; // 카메라 지연 속도 (낮을수록 빠름)

    private void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void LateUpdate()
    {
        if (target == null) 
            return;

        // 목표 위치 계산
        Vector3 targetPosition = target.position + offset;
        // SmoothDamp를 이용해 부드럽게 이동
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref currentVelocity, smoothTime);
    }
}