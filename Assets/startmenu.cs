using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startmenu : MonoBehaviour
{
    public void play(string scene_name){
    	SceneManager.LoadScene(scene_name);
    }

    // public void sound_volume(float volume){
    // 	PlayerPrefs.SetFloat("volume", volume);
    // }

    public void sound_volume(float volume){
        PlayerPrefs.SetFloat("volume",volume);
    }
    
    
}
