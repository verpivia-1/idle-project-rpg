using System.Collections;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    DetecterManeger Detecter;
    GameObject Gun;
    void Start()
    {
        Detecter = FindFirstObjectByType<DetecterManeger>();
        Gun = Resources.Load<GameObject>("Prefebs/Circle");

        StartCoroutine(Attack());
    }
    private IEnumerator Attack()
    {
        while(true)
        {
            if(Detecter.isDetectedEnermy == true)
            { 
                Instantiate(Gun,transform.position,transform.rotation);

                yield return new WaitForSeconds(2f);
            }

            yield return null;
        }
    }
}
