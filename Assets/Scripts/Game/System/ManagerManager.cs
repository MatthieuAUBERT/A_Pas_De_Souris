using UnityEngine;

public class ManagerManager : MonoBehaviour
{
    public static ManagerManager Instance;

    public GameManager gameManager;
    public UIManager uiManager;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
}
