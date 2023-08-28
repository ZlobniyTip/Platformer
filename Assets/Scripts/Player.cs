using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private int _currentCoins;

    private void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out Coin coin))
        {
            _currentCoins++;
            Debug.Log(collision.collider.gameObject.name);
            Debug.Log($"Монет собрано: {_currentCoins}");
            Destroy(collision.collider.gameObject);
        }
    }
}
