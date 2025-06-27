using UnityEngine;

public class CameraFollowInstant : MonoBehaviour
{
    // El objetivo que la cámara seguirá
    public Transform target;

    // Offset opcional
    public Vector3 offset = new Vector3(0f, 0f, -10f);

    void LateUpdate()
    {
        if (target != null)
        {
            // Mover la cámara directamente a la posición deseada
            transform.position = target.position + offset;
        }
    }
}
