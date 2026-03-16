using UnityEngine;

public class IWeapon : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public interface IWeapon0

    {

        bool CanFire { get; }
        void Fire(Vector3 targetPosition);
        void Fire(Vector3 direction, bool useDirection);
    }
}


