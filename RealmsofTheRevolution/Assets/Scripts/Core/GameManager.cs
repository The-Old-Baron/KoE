
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Plataforms plataform;

    private void Awake(){
        switch(Application.platform)
        {
            case RuntimePlatform.WindowsEditor:
            case RuntimePlatform.WindowsPlayer:
                plataform = Plataforms.Windows;
                break;
            case RuntimePlatform.LinuxEditor:
            case RuntimePlatform.LinuxPlayer:
                plataform = Plataforms.Linux;
                break;
            case RuntimePlatform.OSXEditor:
            case RuntimePlatform.OSXPlayer:
                plataform = Plataforms.MacOS;
                break;
            case RuntimePlatform.Android:
                plataform = Plataforms.Android;
                break;
            case RuntimePlatform.IPhonePlayer:
                plataform = Plataforms.IOS;
                break;
            case RuntimePlatform.PS4:
                plataform = Plataforms.PS;
                break;
            case RuntimePlatform.XboxOne:
                plataform = Plataforms.Xbox;
                break;
            case RuntimePlatform.Switch:
                plataform = Plataforms.Switch;
                break;
        }
    }
}