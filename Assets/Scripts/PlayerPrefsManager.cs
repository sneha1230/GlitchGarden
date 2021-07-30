using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour
{
    // Start is called before the first frame update
    const string MASTER_VOLUME_KEY = "master_volume";
    const string DIFFICULT_KEY = "difficulty";
    const string LEVEL_KEY = "level_difficulty_unlocked";
   
    public static void SetMasterVolume(float volume)
    {
        if(volume>0f && volume < 1f)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
        else
        {
            Debug.LogError("Volume Out of Range");
        }
    }
    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }
    private void Start()
    {
        print(GetMasterVolume());
        SetMasterVolume(0.3f);
        print(GetMasterVolume());
    }
}
