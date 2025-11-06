using UnityEngine;

public class AutoShot : Weapon
{
    [SerializeField] private int _count;
    [SerializeField] private float spreadAngle = 10f;
    
    public override void Shoot(Transform shotPoint)
    {
        for (int i = 0; i < _count; i++)
        {
            float angle = Random.Range(-spreadAngle, spreadAngle);
            Quaternion rotation = shotPoint.rotation * Quaternion.Euler(0f, 0f, angle);
            Instantiate(Bullet, shotPoint.position, rotation);
        }
    }
}
