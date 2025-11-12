using UnityEngine;

[RequireComponent(typeof(Animator))]
public class DistanceAttackState : State
{
    [SerializeField] private float _delay;

    [SerializeField] private EnemyBullet _bullet;
    [SerializeField] private Transform _shotPoint;

    private float _lastAttackTime;
    private Animator _animator;
    
    private const string AttackAnimation = "Attack";

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (_lastAttackTime <= 0)
        {
            Attack(Target);
            _lastAttackTime = _delay;
        }

        _lastAttackTime -= Time.deltaTime;
    }

    private void Attack(Player target)
    {
        _animator.Play(AttackAnimation);
        Shoot();
    }

    private void Shoot()
    {
        Instantiate(_bullet, _shotPoint.position, Quaternion.identity);
    }
}