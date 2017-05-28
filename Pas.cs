using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pas : MonoBehaviour {

	
    public void Pass()
    {
        //Pas butonu
        if (KartYarat.sıraKimde == 0&&KartYarat.round==2)
        {
            GameObject.Find("deste").GetComponent<KartYarat>().eldekikartlar.Add("kart atıldı");
            Yoket.kartAttıMı = true;
        }
    }
}
