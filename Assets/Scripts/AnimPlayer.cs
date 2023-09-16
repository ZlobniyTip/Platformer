using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Movement))]

public class AnimPlayer : MonoBehaviour
{
    private Animator _animator;
    private Movement _movement;
    private const string _isRun = nameof(_isRun);

    public class Params
    {
        public static readonly int IsRun = Animator.StringToHash(nameof(IsRun));
    }

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _movement = GetComponent<Movement>();
    }

    private void Update()
    {
        SetupAnimation();
    }

    private void SetupAnimation()
    {
        _animator.SetBool(AnimPlayer.Params.IsRun, _movement.IsRun);
    }
}
