using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private Vector3 _rotationSpeed;
    void Update()
    {
        transform.Rotate( _rotationSpeed );
    }
}
