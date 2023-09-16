using UnityEngine;

public class Player : MonoBehaviour
{
    private int _currentCoins;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out Coin coin))
        {
            _currentCoins++;
            Destroy(collision.collider.gameObject);
        }
    }
}
