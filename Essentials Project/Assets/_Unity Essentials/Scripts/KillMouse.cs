using UnityEngine;

public class KillMouse : MonoBehaviour
{
    [SerializeField] private GameObject _onCollectEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<PlayerController2D>(out PlayerController2D player))
        {
            Destroy(player.gameObject);
            Instantiate(_onCollectEffect, player.transform.position, player.transform.rotation);
        } 
    }
}
