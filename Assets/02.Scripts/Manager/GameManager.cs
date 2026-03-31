using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }

        Init();
    }

    private void Init()
    {
        Application.targetFrameRate = 65;
        Screen.SetResolution(1080, 1920, true);
    }
}