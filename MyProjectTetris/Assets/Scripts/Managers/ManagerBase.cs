using UnityEngine;

public class ManagerBase : MonoBehaviour
{
    public virtual void Initialize()
    {
        Debug.Log($"{GetType().Name} initialized");
    }
}
