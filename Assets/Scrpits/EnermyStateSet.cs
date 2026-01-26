using UnityEngine;

public class EnermyStateSet : MonoBehaviour
{
    public int Hp { get; set; } = 1;

    void Update()
    {
        if(Hp == 0)
        {
            Destroy(gameObject);
        }
    }
}
