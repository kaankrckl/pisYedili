using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joker : MonoBehaviour {
    public static bool club;
    public static bool spade;
    public static bool heart;
    public static bool diamond;
    public void C()
    {
        print("kart club yapıldı");
        club = true;
        if (KartYarat.akış == true)
        {
            KartYarat.sıraKimde = 1;
        }
        if (KartYarat.akış == false)
        {
            KartYarat.sıraKimde = 3;
        }
        GameObject.Find("deste").GetComponent<KartYarat>().eldekikartlar.Add("kart atıldı");
        Yoket.kartAttıMı = true;
    }
    public void S()
    {
        print("kart spade yapıldı");
        spade = true;
        if (KartYarat.akış == true)
        {
            KartYarat.sıraKimde = 1;
        }
        if (KartYarat.akış == false)
        {
            KartYarat.sıraKimde = 3;
        }
        GameObject.Find("deste").GetComponent<KartYarat>().eldekikartlar.Add("kart atıldı");
        Yoket.kartAttıMı = true;
    }
    public void H()
    {
        print("kart heart yapıldı");
        heart = true;
        if (KartYarat.akış == true)
        {
            KartYarat.sıraKimde = 1;
        }
        if (KartYarat.akış == false)
        {
            KartYarat.sıraKimde = 3;
        }
        GameObject.Find("deste").GetComponent<KartYarat>().eldekikartlar.Add("kart atıldı");
        Yoket.kartAttıMı = true;
    }
    public void D()
    {
        print("kart diamond yapıldı");
        diamond = true;
        if (KartYarat.akış == true)
        {
            KartYarat.sıraKimde = 1;
        }
        if (KartYarat.akış == false)
        {
            KartYarat.sıraKimde = 3;
        }
        GameObject.Find("deste").GetComponent<KartYarat>().eldekikartlar.Add("kart atıldı");
        Yoket.kartAttıMı = true;
    }
}
