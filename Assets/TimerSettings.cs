using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSettings : MonoBehaviour
{
    public Text TextTimer;
    public float Waktu = 100;
    public bool GameAktif = true;
    public GameObject PopUp, Menang;
    int terjawab=0;
    
    
    
    void SetText(){
        int Menit = Mathf.FloorToInt(Waktu / 60);
        int Detik = Mathf.FloorToInt(Waktu % 60);
        TextTimer.text = Menit.ToString("00")+":"+ Detik.ToString("00");
    }

    public void random_object(){
        for(int i=0; i < transform.childCount; i++){
            transform.GetChild(i).gameObject.SetActive(false);
        }

        int a = Random.Range(0,transform.childCount);

        if(transform.GetChild(a).name != "terjawab")
        {
            terjawab += 1;
            transform.GetChild(a).gameObject.SetActive(true);
            transform.GetChild(a).name = "terjawab";
        }
        else{
            if(terjawab < transform.childCount){
                random_object(); 
            }
            else{
                Menang.SetActive(true);                
            }            
        }
    }
    float s;
    private void Update()
    {  
        if(GameAktif)
        {
            s += Time.deltaTime;
            if(s >= 1)
            {
                Waktu--;
                s = 0;
            }        
        }

        if(GameAktif && Waktu <= 0)
        {            
            PopUp.SetActive(true);
            GameAktif = false;
        }       

        // if(GameAktif && terjawab==transform.childCount){
        //     GameAktif=false;
        //     Menang.SetActive(true);
            
        // }

        SetText();          
    }

    
}
