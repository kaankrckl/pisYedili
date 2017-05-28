using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SahneYönet : MonoBehaviour {
   
   
    public void Oynna()
    {
        //Yeni sahneye Geçiş
       
        SceneManager.LoadScene("3lügame");
    }
    public void Kurallar()
    {
        //Kurallar Sayfasını aç
        SceneManager.LoadScene("Kurallar");
    }
    public void Çıkış()
    {
        //Oyundan çık
        Application.Quit();
        Debug.Log("Çıkış yapılıyor");
    }
    public void Geri()
    {
        SceneManager.LoadScene("AnaSayfa");
    }
  
    
}
