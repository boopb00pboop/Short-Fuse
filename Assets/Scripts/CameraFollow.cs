using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float smoothTime = 0.2f;

    private Vector2 followVelocity;

    private void LateUpdate()
    {
        Vector2 currentPosition = transform.position;
        Vector2 targetPosition = target.position;

        Vector2 newPosition = Vector2.SmoothDamp(currentPosition, targetPosition, ref followVelocity, smoothTime);

        transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
    }


}
