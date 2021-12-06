using UnityEngine;

public class UILoading : MonoBehaviour
{
    public bool mustLoadUIOnStart;
    private UIManager uiManager;

    private void Start()
    {
        uiManager = ManagerManager.Instance.uiManager;        
        uiManager.SetMainUIActive(mustLoadUIOnStart);
    }


    private void Update()
    {
        
    }
}
