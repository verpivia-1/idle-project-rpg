using System.Runtime.CompilerServices;
using UnityEngine;

public class DetecterManeger : MonoBehaviour
{
    public bool isDetectedPlayer { get; private set; } = false;
    public bool isDetectedEnermy { get; private set; } = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enermy")
        {
            isDetectedEnermy = true;
        }

        else if (collision.tag == "Player")
        {
            isDetectedPlayer = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enermy"))
        {
            isDetectedEnermy = false;
        }
        else if (collision.CompareTag("Player"))
        {
            isDetectedPlayer = false;
        }

    }
}
