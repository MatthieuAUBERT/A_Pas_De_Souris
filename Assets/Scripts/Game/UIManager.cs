using UnityEngine;

public class UIManager : MonoBehaviour
{

    public GameObject mainUI;
    public void SetMainUIActive(bool b)
    {
        mainUI.SetActive(b);
    }
   
}
