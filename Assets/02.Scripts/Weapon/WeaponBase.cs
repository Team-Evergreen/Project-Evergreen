using UnityEngine;

public abstract class WeaponBase : MonoBehaviour
{
    public WeaponData data;

    protected virtual void Attack()
    {
        if (data.isMelee)
        {
            MeleeAttack();
        }
        else
        {
            RangedAttack();
        }
    }

    // 근거리 공격 실행
    private void MeleeAttack()
    {
        // 도끼처럼 휘두르는 로직 (애니메이션 재생 및 범위 판정)
        Debug.Log($"{data.weaponName}으로 근접 공격!");
        Collider2D[] enemies = Physics2D.OverlapCircleAll(transform.position, data.range);
        // 대미지 입히는 로직...
    }

    // 사거리 공격 실행
    private void RangedAttack()
    {
        // 총알을 발사하는 로직
        Debug.Log($"{data.weaponName}으로 원거리 사격!");
        Instantiate(data.projectilePrefab, transform.position, transform.rotation);
    }
}