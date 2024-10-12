using UnityEngine;

public abstract class SingletonMonoBehaviourWithInterface<CT, IT> : MonoBehaviour where CT : SingletonMonoBehaviourWithInterface<CT, IT>, IT
{
    protected static CT _instance;
    public static CT instance => _instance ?? (_instance = FindObjectOfType<CT>());
    public static bool instanceExistis => _instance != null;

    protected virtual void Awake()
    {
        if (!(instance == this))
        {
            _instance = (CT)this;
        }
    }
    protected virtual void OnDestroy()
    {
        if (instance == this)
        {
            _instance = null;
        }
    }
}