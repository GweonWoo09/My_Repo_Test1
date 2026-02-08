using UnityEngine;

public class TitleCommander : CommanderBase
{
    [SerializeField]
    private CommanderChildBase[] _childCommanders;

    private void Awake()
    {
        foreach (var childCommander in _childCommanders)
        {
            childCommander.Initialize(this);
        }
    }

    public void StartGame()
    {
        Managers.Game.SetState(GameManager.GameState.Game);
    }
}
