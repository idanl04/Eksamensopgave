using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;    // the target object to follow
    public float smoothing = 5f;    // the speed at which the camera will follow the target

    private Vector3 offset;    // the initial offset between the camera and the target

    void Start()
    {
        offset = transform.position - target.position;
    }

    void FixedUpdate()
    {
        Vector3 targetCamPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}
