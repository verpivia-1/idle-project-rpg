using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BullitFire : MonoBehaviour
{
    List<GameObject> enemies;
    private float speed = 4f;
    private Vector3 findEnermy;
    EnermyStateSet EnermyState;
    void Start()
    {
        StartCoroutine(Fire());
    }
    private void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enermy").ToList();
        
    }
    private IEnumerator Fire()
    {
            if (enemies.Count > 0)
            {
                // 2. 가장 가까운 적을 찾기
                GameObject target = null;
                float minDistance = Mathf.Infinity;

                foreach (GameObject enemy in enemies)
                {
                    float distance = Vector3.Distance(transform.position, enemy.transform.position);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        target = enemy;
                    }
                }
                // 3. 타겟이 결정되면 그 위치를 향해 이동 시작
                if (target != null)
                {
                    Vector3 targetPos = target.transform.position;

                    while (Vector3.Distance(transform.position, targetPos) > 0.1f)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, targetPos, Time.deltaTime * speed);
                        yield return null;
                    }
                }
            }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enermy")
        {
            EnermyStateSet enemyState = collision.GetComponent<EnermyStateSet>();
            enemyState.Hp--;

            Destroy(gameObject);
        }
    }
}

