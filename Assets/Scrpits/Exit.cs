using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    private Button exit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        exit = GetComponent<Button>();

        exit.onClick.AddListener(ExitGame);
    }
    private void ExitGame()
    {
        Application.Quit();
    }
}
