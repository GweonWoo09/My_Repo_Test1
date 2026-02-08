using UnityEngine;

public class GameOver : MonoBehaviour
{
    void Start()
    {
        Managers.Game.SetState(GameManager.GameState.Game);
    }
}