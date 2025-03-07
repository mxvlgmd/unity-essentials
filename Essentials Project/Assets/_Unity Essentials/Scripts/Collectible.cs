using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] private Vector3 _rotationSpeed;
    [SerializeField] private GameObject _onCollectEffect;

    private int _collector; 

    void Update()
    {
        transform.Rotate(_rotationSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<PlayerController>(out PlayerController player))
        {
            Destroy(gameObject);
            Instantiate(_onCollectEffect, transform.position, transform.rotation);
            player.AddItem();
        }
    }
}