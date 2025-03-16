using UnityEngine;

public class BallTouch : MonoBehaviour
{
    [SerializeField] public AudioClip TouchSound;
    [SerializeField] private AudioSource _touchSource;
    void Start()
    {
        _touchSource = gameObject.AddComponent<AudioSource>();
        _touchSource.clip = TouchSound;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity != Vector3.zero)
        {
            _touchSource.Play();
        }
    }
}
