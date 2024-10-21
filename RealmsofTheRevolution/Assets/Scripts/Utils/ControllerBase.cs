using UnityEngine;

public abstract class ControllerBase : MonoBehaviour
{
    public abstract void Initialize();
    public virtual void InitializeLevel(){}
    protected virtual void Awake()
    {
        // Add this line to Awake method
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}