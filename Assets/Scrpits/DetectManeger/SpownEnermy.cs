using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpownEnermy : MonoBehaviour
{
    GameObject Monster;
    private Rect canSpownArea;
    private float SpownEnermyX;
    private float SpownEnermyY;

    void Start()
    {
        Vector3 RectArea = transform.position;
        canSpownArea = new Rect(RectArea.x,RectArea.y,2f,2f);
        Monster = Resources.Load<GameObject>("Prefebs/Lost_Soul1");
        StartCoroutine(MonsterSpown());
    }
    private IEnumerator MonsterSpown()
    {
        while (true)
        {
            SpownEnermyX = Random.Range(canSpownArea.xMin,canSpownArea.xMax);
            SpownEnermyY = Random.Range(canSpownArea.yMin,canSpownArea.yMax);
            Vector3 SpownPoint = new Vector3(SpownEnermyX,SpownEnermyY);

            Instantiate(Monster);
            Monster.name = "Lost Soul1";
            Monster.transform.position = SpownPoint;
            yield return new WaitForSeconds(3);
        }
    }
}
