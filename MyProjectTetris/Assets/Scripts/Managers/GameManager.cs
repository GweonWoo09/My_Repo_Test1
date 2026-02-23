using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : ManagerBase
{
    public enum GameState
    {
        Loading,
        Title,
        Game,
        Result
    }

    public GameState _CurrentState = GameState.Loading;
    public void SetState(GameState newState)
    {
        _CurrentState = newState;
        SceneManager.LoadScene(_CurrentState.ToString());
    }

    public override void Initialize()
    {
        base.Initialize();
    }


}
