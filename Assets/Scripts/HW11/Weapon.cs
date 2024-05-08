using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public abstract void Fire();
}

public class Pistol : Weapon, IReloadable
{
    public override void Fire()
    {
        //Shooting pistol
        Debug.Log("Pistol is shooting..");
    }

    public void Reload()
    {
        //Pistol reloading
        Debug.Log("Pistol is reloading");
    }
}

public class Rifle : Weapon, IReloadable
{
    public override void Fire()
    {
        //Shooting rifle
        Debug.Log("Rifle is shooting..");
    }

    public void Reload()
    {
        //Rifle reloading
        Debug.Log("Rifle is reloading");
    }
}

public class Knife : Weapon
{
    public override void Fire()
    {
        //Attacking knife
        Debug.Log("Attacking from Knife");
    }
}

public class WeaponController : MonoBehaviour
{
    private Weapon currentWeapon;

    public void EquipWeapon(Weapon weapon)
    { 
        currentWeapon = weapon;
    }

    public void FireWeapon()
    {
        if (currentWeapon != null)
        {
            currentWeapon.Fire();
        }
        else
        {
            Debug.Log("U don't have any weapon");
        }
    }
}

public interface IReloadable
{
    public void Reload()
    { 
        //Reload System
    }
}
