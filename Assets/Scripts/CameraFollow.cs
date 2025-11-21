using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform cameraPoint;
    [SerializeField] Transform camera;
    [SerializeField] float smoothTime;

    Vector3 velocity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        camera.position = Vector3.SmoothDamp(camera.position, cameraPoint.position, ref velocity, smoothTime);
    }
}
