using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shuffle : MonoBehaviour
{
    public List<Transform> soal = new List<Transform>();
    int terjawab = 0;
    public GameObject Menang;
    public void random_object(){        
        for(int i=0; i < transform.childCount; i++){
            soal.Add(transform.GetChild(i));
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

    // Update is called once per frame
    void Update()
    {
        
    }
}