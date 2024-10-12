using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Manager : MonoBehaviour
{
    public abstract void Initialize();  
    public virtual void OnLevelLoaded() { }

    protected bool HasAuth()
    {

        // Necessario verificar na rede se o jogador é o host ou autor do save
        return true;
    }
}
