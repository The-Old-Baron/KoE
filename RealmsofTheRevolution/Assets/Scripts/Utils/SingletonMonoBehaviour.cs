using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
    protected static T _instance;
    public static T instance => _instance ?? (_instance = FindObjectOfType<T>());
    public static bool instanceExistis => _instance != null;

    protected virtual void Awake()
    {
        if (!(instance == this))
        {
            _instance = (T)this;
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
