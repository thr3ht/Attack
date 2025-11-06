using UnityEngine;

public class SingleShot : Weapon
{
    public override void Shoot(Transform shotPoint)
    {
        Instantiate(Bullet, shotPoint.position, Quaternion.identity);
    }
}
