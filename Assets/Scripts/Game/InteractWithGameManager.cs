using UnityEngine;

public class InteractWithGameManager : MonoBehaviour
{
    GameManager gm;

    private void Awake()
    {
        gm = ManagerManager.Instance.gameManager;
    }

    public void ClueAdd(string clueName)
    {
        gm.clues.Add(clueName);
    }

}
