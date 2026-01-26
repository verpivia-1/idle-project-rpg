using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainScene : MonoBehaviour
{
    private Button StartButton;
    void Start()
    {
        StartButton = GetComponent<Button>();
        StartButton.onClick.AddListener(SceneChange);
    }

    private void SceneChange()
    {
        SceneManager.LoadScene("idle Field");
    }
}
