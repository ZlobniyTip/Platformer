using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointMovement : MonoBehaviour
{
    [SerializeField] private Transform _path;
    [SerializeField] private float _speed;
    [SerializeField] private Transform[] _points;
    private SpriteRenderer _spriteRenderer;
    private int _currentPoint;
    private bool _turn = false;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Transform target = _points[_currentPoint];

        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

        if (transform.position == target.position)
        {
            _currentPoint++;
            _spriteRenderer.flipX = TurnAround(ref _turn);

            if (_currentPoint >= _points.Length)
            {
                _currentPoint = 0;
            }
        }
    }

    private bool TurnAround(ref bool turn)
    {
        if (turn)
        {
            return turn = false;
        }

        return turn = true;
    }
}
