using UnityEngine;

public class GameSet : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit(); // 빌드된 게임 종료
        }
    }
}
