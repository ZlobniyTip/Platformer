using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimPlayer : MonoBehaviour
{
    private Animator _animator;
    private Movement _movement;
    private const string IsRun = nameof(IsRun);

    public class Params
    {
        public static readonly int _isRun = Animator.StringToHash(nameof(_isRun));
    }

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _movement = GetComponent<Movement>();
    }

    private void Update()
    {
        LogParameters();
        Setup();
    }

    private void LogParameters()
    {
        bool isRun = _animator.GetBool(AnimPlayer.Params._isRun);
    }

    private void Setup()
    {
        if (_movement.IsRun == true)
        {
            _animator.SetBool(AnimPlayer.Params._isRun, true);
        }
        else if (_movement.IsRun == false)
        {
            _animator.SetBool(AnimPlayer.Params._isRun, false);
        }
    }
}
