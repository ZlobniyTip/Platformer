using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jump;

    private SpriteRenderer _spriteRenderer;
    private bool _isRun;

    public bool IsRun => _isRun;
    public float Speed => _speed;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        _isRun = false;

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);
            _spriteRenderer.flipX = false;
            _isRun = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
            _spriteRenderer.flipX = true;
            _isRun = true;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, _jump * Time.deltaTime, 0);
        }
    }
}
