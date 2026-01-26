using System.Collections;
using UnityEngine;

public class SoulMove : MonoBehaviour
{
    GameObject Chaser;
    DetecterManeger Detecter;
    float speed = 3f;
    public bool isReadyToAttack { get; private set; } = false;

    void Start()
    {
        Detecter = FindFirstObjectByType<DetecterManeger>();
        Chaser = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(chasePLayer());
    }
    private IEnumerator chasePLayer()
    {
        while (true)
        {
            if (isReadyToAttack == false && Detecter.isDetectedPlayer == false)
            {
                transform.position = Vector3.MoveTowards(transform.position, Chaser.transform.position, Time.deltaTime * speed);

                if (Detecter.isDetectedPlayer == true)
                {
                    isReadyToAttack = true;
                }
                if (Chaser.activeSelf == false)
                {
                    isReadyToAttack = false;
                }
            }
            yield return null; // 무한 루프 겜터짐 방지용
        }
    }
    
           
    
}
