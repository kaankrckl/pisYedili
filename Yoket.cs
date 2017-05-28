using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yoket : MonoBehaviour {
    public static bool kartAttıMı;
    public static bool kartCektıMı=false;
    
    void Start()
    {
        GameObject.Find("deste").GetComponent<KartYarat>().KartAtıldıMıBak();
        print(KartYarat.round);
        print(kartAttıMı+"BAK");
       

    }
    
    void OnMouseDown()
    {
        
        if (KartYarat.sıraKimde == 0)
        {
            print(KartYarat.round + "BİLGİLER" + kartAttıMı + gameObject.name);
           // print(gameObject.GetComponent<SpriteRenderer>().sprite.name.Substring(4, 5));
          //  print(gameObject.GetComponent<SpriteRenderer>().sprite.name.Substring(gameObject.GetComponent<SpriteRenderer>().sprite.name.Length - 1));
          
            if (KartYarat.round == 1 && gameObject.GetComponent<SpriteRenderer>().sprite.name.Substring(0, 9) == "cardClubs" && GameObject.Find("deste").GetComponent<KartYarat>().KartAtıldıMıBak() == false && gameObject.GetComponent<SpriteRenderer>().sprite.name != "cardClubsA" && gameObject.GetComponent<SpriteRenderer>().sprite.name != "cardClubsJ" && gameObject.GetComponent<SpriteRenderer>().sprite.name != "cardClubs10" && gameObject.GetComponent<SpriteRenderer>().sprite.name != "cardClubs7")
            {


                GameObject.Find("deste").GetComponent<KartYarat>().eldekikartlar.Remove(gameObject.GetComponent<SpriteRenderer>().sprite.name);
                GameObject.Find("deste").GetComponent<KartYarat>().eldekikartlar.Add("kart atıldı");
                GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite = gameObject.GetComponent<SpriteRenderer>().sprite;
                GameObject.Find("deste").GetComponent<KartYarat>().yerdekikartlar.Add(gameObject.GetComponent<SpriteRenderer>().sprite);
                Destroy(gameObject.GetComponent<SpriteRenderer>());
                KartYarat.sıraKimde = 1;

            }

          if (KartYarat.round == 2 && (gameObject.GetComponent<SpriteRenderer>().sprite.name.Substring(0, 9) == GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(0, 9) || GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Length - 1) == gameObject.GetComponent<SpriteRenderer>().sprite.name.Substring(gameObject.GetComponent<SpriteRenderer>().sprite.name.Length - 1)) && GameObject.Find("deste").GetComponent<KartYarat>().KartAtıldıMıBak() == false)
            {
                //10 atarsak
               if (gameObject.GetComponent<SpriteRenderer>().sprite.name.Substring(gameObject.GetComponent<SpriteRenderer>().sprite.name.Length - 1) == "0")
                {
                    GameObject.Find("deste").GetComponent<KartYarat>().eldekikartlar.Remove(gameObject.GetComponent<SpriteRenderer>().sprite.name);
                    GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite = gameObject.GetComponent<SpriteRenderer>().sprite;
                    GameObject.Find("deste").GetComponent<KartYarat>().yerdekikartlar.Add(gameObject.GetComponent<SpriteRenderer>().sprite);
                    GameObject.Find("deste").GetComponent<KartYarat>().eldekikartlar.Add("kart atıldı");
                    kartAttıMı = true;
                    KartYarat.akış = !KartYarat.akış;
                    KartYarat.kac7 = 0;
                    Destroy(gameObject.GetComponent<SpriteRenderer>());
                    
                }
               //7 atılınca
               else if (gameObject.GetComponent<SpriteRenderer>().sprite.name.Substring(gameObject.GetComponent<SpriteRenderer>().sprite.name.Length - 1) == "7")
                {
                    GameObject.Find("deste").GetComponent<KartYarat>().eldekikartlar.Remove(gameObject.GetComponent<SpriteRenderer>().sprite.name);
                    GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite = gameObject.GetComponent<SpriteRenderer>().sprite;
                    GameObject.Find("deste").GetComponent<KartYarat>().yerdekikartlar.Add(gameObject.GetComponent<SpriteRenderer>().sprite);
                    GameObject.Find("deste").GetComponent<KartYarat>().eldekikartlar.Add("kart atıldı");
                    kartAttıMı = true;
                    KartYarat.kac7++;
                    Destroy(gameObject.GetComponent<SpriteRenderer>());

                }
                //7

                //Jilet atarsak
                else if (gameObject.GetComponent<SpriteRenderer>().sprite.name.Substring(gameObject.GetComponent<SpriteRenderer>().sprite.name.Length - 1) == "J")
                {
                    GameObject.Find("deste").GetComponent<KartYarat>().eldekikartlar.Remove(gameObject.GetComponent<SpriteRenderer>().sprite.name);
                    GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite = gameObject.GetComponent<SpriteRenderer>().sprite;
                    GameObject.Find("deste").GetComponent<KartYarat>().yerdekikartlar.Add(gameObject.GetComponent<SpriteRenderer>().sprite);
                    KartYarat.sıraKimde = 0;
                    Destroy(gameObject.GetComponent<SpriteRenderer>());

                }

                //Jilet atarsak

                //As atarsak
                else if (gameObject.GetComponent<SpriteRenderer>().sprite.name.Substring(gameObject.GetComponent<SpriteRenderer>().sprite.name.Length - 1) == "A")
                {
                    GameObject.Find("deste").GetComponent<KartYarat>().eldekikartlar.Remove(gameObject.GetComponent<SpriteRenderer>().sprite.name);
                    GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite = gameObject.GetComponent<SpriteRenderer>().sprite;
                    GameObject.Find("deste").GetComponent<KartYarat>().yerdekikartlar.Add(gameObject.GetComponent<SpriteRenderer>().sprite);
                    Destroy(gameObject.GetComponent<SpriteRenderer>());
                    KartYarat.sıraKimde = 0;
                    KartYarat.kac7 = 0;
                }
               else
                {
                    GameObject.Find("deste").GetComponent<KartYarat>().eldekikartlar.Remove(gameObject.GetComponent<SpriteRenderer>().sprite.name);
                    GameObject.Find("deste").GetComponent<KartYarat>().eldekikartlar.Add("kart atıldı");
                    kartAttıMı = true;
                    GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite = gameObject.GetComponent<SpriteRenderer>().sprite;
                    GameObject.Find("deste").GetComponent<KartYarat>().yerdekikartlar.Add(gameObject.GetComponent<SpriteRenderer>().sprite);
                    Destroy(gameObject.GetComponent<SpriteRenderer>());
                    KartYarat.sıraKimde = 1;
                    KartYarat.kac7 = 0;
                }
                
                
            }
           
            if (KartYarat.round != 1 && kartAttıMı == false && gameObject == GameObject.Find("deste") && kartCektıMı == false)
            {

                for (int i = 1; i <= 16; i++)
                {
                    if (GameObject.Find("KartYeri" + i).GetComponent<SpriteRenderer>() == null)
                    {
                        if (GameObject.Find("KartYeri" + i).GetComponent<SpriteRenderer>() == null)
                        {
                            GameObject.Find("KartYeri" + i).AddComponent<SpriteRenderer>();
                            GameObject.Find("KartYeri" + i).GetComponent<SpriteRenderer>().sprite = GetComponent<KartYarat>().kartlar[GetComponent<KartYarat>().kartlar.Count - 1];
                            GetComponent<KartYarat>().kartlar.Remove(GetComponent<KartYarat>().kartlar[GetComponent<KartYarat>().kartlar.Count - 1]);
                            kartCektıMı = true;
                          //  kartAttıMı = true;
                            KartYarat.sıraKimde = 0;
                            return;
                        }


                    }

                }
                  kartCektıMı = false;


            }


        }
       


   }

}
