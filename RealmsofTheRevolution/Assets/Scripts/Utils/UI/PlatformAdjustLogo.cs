using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAdjustLogo : MonoBehaviour
{
    public SpriteRenderer logo;
    public Sprite windowsLogo;
    public Sprite linuxLogo;
    public Sprite macOsLogo;
    public Sprite androidLogo;
    public Sprite iOSLogo;
    public Sprite psLogo;
    public Sprite xboxLogo;
    public Sprite switchLogo;

    private void Start(){
        switch (Application.platform)
        {
            case RuntimePlatform.WindowsEditor:
            case RuntimePlatform.WindowsPlayer:
                logo.sprite = windowsLogo;
                break;
            case RuntimePlatform.LinuxEditor:
            case RuntimePlatform.LinuxPlayer:
                logo.sprite = linuxLogo;
                break;
            case RuntimePlatform.OSXEditor:
            case RuntimePlatform.OSXPlayer:
                logo.sprite = macOsLogo;
                break;
            case RuntimePlatform.Android:
                logo.sprite = androidLogo;
                break;
            case RuntimePlatform.IPhonePlayer:
                logo.sprite = iOSLogo;
                break;
            case RuntimePlatform.PS4:
                logo.sprite = psLogo;
                break;
            case RuntimePlatform.XboxOne:
                logo.sprite = xboxLogo;
                break;
            case RuntimePlatform.Switch:
                logo.sprite = switchLogo;
                break;
            default:
                break;
        }
    }
}
