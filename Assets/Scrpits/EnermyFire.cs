using System.Collections;
using UnityEngine;

public class EnermyFire : MonoBehaviour
{
    DetecterManeger Detecter;
    GameObject Fire;
    void Start()
    {
        Detecter = FindFirstObjectByType<DetecterManeger>();
        Fire = Resources.Load<GameObject>("Prefebs/LostFlare1");

        StartCoroutine(Attack());
    }
    private IEnumerator Attack()
    {
        while (true)
        {
            if (Detecter.isDetectedPlayer == true)
            {
                Instantiate(Fire, transform.position, transform.rotation);

                yield return new WaitForSeconds(2f);
            }

            yield return null;
        }
    }
}
