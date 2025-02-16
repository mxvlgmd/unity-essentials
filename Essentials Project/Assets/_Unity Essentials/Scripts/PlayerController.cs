using Unity.Mathematics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]private float _speed;
    [SerializeField]private float _rotationSpeed;
 
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = transform.forward * moveVertical * _speed * Time.fixedDeltaTime;
        _rigidbody.MovePosition(_rigidbody.position + movement);
        float turn = Input.GetAxis("Horizontal");
        Quaternion turnRotation = Quaternion.Euler(0f,turn,0f);
        _rigidbody.MoveRotation(_rigidbody.rotation * turnRotation);
    }
}
