using System.Collections;
using UnityEngine;

public class EnermyBullitFire : MonoBehaviour
{
    GameObject Chaser;
    private float speed = 4f;
    private Vector3 findPlayer;

    void Start()
    {
        Chaser = GameObject.FindGameObjectWithTag("Player");
        findPlayer = Chaser.transform.position;

        StartCoroutine(Fire());
    }
    private IEnumerator Fire()
    {
        while (true)
        {
            transform.position = Vector3.MoveTowards(transform.position, findPlayer, Time.deltaTime * speed);
            yield return null;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

}


