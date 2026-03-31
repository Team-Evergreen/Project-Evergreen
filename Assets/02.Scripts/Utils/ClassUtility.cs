using System;
using Utils.EnumType;
using System.Collections.Generic;

namespace Utils.ClassUtility
{
    // 플레이어 데이터 구조
    [Serializable]
    public class WeaponDataList
    {
        public List<WeaponData> Weapons;
    }

    [Serializable]
    public class WeaponData
    {
        public string weaponName;
        public string projectilePrefab;
        public string weaponAnim;
        public WeaponType weaponType;
        public EquipTarget equipTarget;
        public float speed;
        public float damage;
        public float fireRate;
        public float range;
        public bool isMelee;
    }
}