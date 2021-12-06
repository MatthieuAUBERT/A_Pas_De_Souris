using UnityEngine;

public class InteractWithGameManager : MonoBehaviour
{
    GameManager gm;

    private void Awake()
    {
        gm = ManagerManager.Instance.gameManager;
    }

    public void AddClue(string clueName)
    {
        gm.clues.Add(clueName);
    }

}
