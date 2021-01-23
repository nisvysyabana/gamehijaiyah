using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class cek : MonoBehaviour
{
	
	public GameObject feed_benar, feed_salah;
	public GameObject Menang;
	int terjawab = 0;
    // Start is called before the first frame update
    void Start()
    {
        // PlayerPrefs.SetInt("skor", 0);
    }
	
	public void jawaban(bool jawab){
		if(jawab){
			feed_benar.SetActive(false);
			feed_benar.SetActive(true);
			int skor = PlayerPrefs.GetInt("skor")+3;
			PlayerPrefs.SetInt("skor", skor);
		}
		else{
			feed_salah.SetActive(false);
			feed_salah.SetActive(true);
		}		
		gameObject.SetActive(false);
		// transform.parent.GetChild(gameObject.transform.GetChildCount () + 1).gameObject.SetActive(true);
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

	

    // Update is called once per frame
    void Update()
    {
        
    }
}
