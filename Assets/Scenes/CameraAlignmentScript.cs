using UnityEngine;

public class CameraAlignmentScript : MonoBehaviour
{
    // Reference to the main camera
    private Transform cameraTransform;

    private void Start()
    {
        // Get the main camera's transform
        cameraTransform = Camera.main.transform;

    }

    private void LateUpdate()
    {
        // Get the camera's rotation
        Quaternion cameraRotation = cameraTransform.rotation;

        // Create a new rotation that only considers the Y-axis rotation of the camera
        Quaternion newRotation = Quaternion.Euler(cameraRotation.eulerAngles.x, cameraRotation.eulerAngles.y, cameraRotation.eulerAngles.z);

        //Debug.Log("New Rotation Euler Angles: " + newRotation.eulerAngles);
        
        // Apply the new rotation to the object
        transform.rotation = newRotation;
    }
}

