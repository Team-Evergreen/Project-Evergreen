using UnityEngine;

// 투사체 기본 동작
public class Projectile : MonoBehaviour
{
    private float damage;
    private float speed;

    public void Setup(float dmg, float spd)
    {
        damage = dmg;
        speed = spd;
        // 5초 뒤 자동 소멸
        Destroy(gameObject, 5f);
    }

    private void Update()
    {
        // 앞으로 전진
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D _collision)
    {
        if (_collision.CompareTag("Enemy"))
        {
            // Enemy 스크립트의 TakeDamage 호출 (인터페이스 사용 권장)
            // collision.GetComponent<IEntity>().TakeDamage(damage);

            // 관통 기능이 없다면 파괴
            Destroy(gameObject);
        }
    }
}