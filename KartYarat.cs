using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class KartYarat : MonoBehaviour
{
    public List<string> isimler = new List<string> { "Ali", "Canan", "Berk", "Sinem", "Selen" };
    public List<Sprite> kartlar;
    public List<Sprite> yerdekikartlar;
    public Sprite sprite;
    public static int round = 0;
    public List<string> eldekikartlar;
    int tıklamasayısı = 0;
    public static bool akış =true;
    public static int sıraKimde = 1;
    public List<Sprite> bot1;
    public List<Sprite> bot2;
    public List<Sprite> bot3;
 
    public int counter;
    public bool bot1kartattıMı;
    public bool bot2kartattıMı;
    public bool bot3kartattıMı;
    public bool kartVarMı;
    public static int kac7=0;
    public bool yediVar;
    bool hic7=false;
    bool bak=false;
    void Start()
    {
        
        GameObject.FindGameObjectWithTag("oksol").transform.localScale = new Vector3(0, 0, 0);
        GameObject.FindGameObjectWithTag("okorta").transform.localScale = new Vector3(0, 0, 0);
        GameObject.FindGameObjectWithTag("oksag").transform.localScale = new Vector3(0, 0, 0);
        GameObject.FindGameObjectWithTag("birinci").GetComponent<Text>().text = isimler[Random.Range(0, isimler.Count)];
        GameObject.FindGameObjectWithTag("ikinci").GetComponent<Text>().text = isimler[Random.Range(0, isimler.Count)];
        GameObject.FindGameObjectWithTag("üçüncü").GetComponent<Text>().text = isimler[Random.Range(0, isimler.Count)];
        sıraKimde = 0;


    }
    public void dagıtBot()
    {
        for (int i = 1; i <= 7; i++)
        {
            int index = Random.Range(0, kartlar.Count);
            bot1.Add(kartlar[index]);
            kartlar.RemoveAt(index);
        }
        for (int i = 1; i <= 7; i++)
        {
            int index = Random.Range(0, kartlar.Count);
            bot2.Add(kartlar[index]);
            kartlar.RemoveAt(index);
        }
        for (int i = 1; i <= 7; i++)
        {
            int index = Random.Range(0, kartlar.Count);
            bot3.Add(kartlar[index]);
            kartlar.RemoveAt(index);
        }
    }
    public void asd(int indexxxxx)
    {
        int index = Random.Range(0, kartlar.Count);
        GameObject.Find("KartYeri" + indexxxxx).GetComponent<SpriteRenderer>().sprite = kartlar[index];
        eldekikartlar.Add(kartlar[index].name);
        kartlar.RemoveAt(index);
    }
    void OnMouseDown()
    {

        if (round == 0)
        {
            //bot1 in eli
            //buraya
            dagıtBot();
            //buraya
            //Oyuncunun eli
        
            for (int i  = 1; i  <=8 ; i ++)
            {
                asd(i);
            }
          


            round++;
            for (int i = 0; i < bot1.Count; i++)
            {
                print("bot1 in eli : " + bot1[i].name);
            }
            for (int i = 0; i < bot2.Count; i++)
            {
                print("bot2 nin eli : " + bot2[i].name);
            }
            for (int i = 0; i < bot3.Count; i++)
            {
                print("bot3ün eli : " + bot3[i].name);
            }
            print(round);
        }
        KartAtıldıMıBak();


        
        if (round == 1 && KartAtıldıMıBak() == false)
        {

            if (tıklamasayısı == 1)
            {

         
                int index9 = Random.Range(0, kartlar.Count);
                GameObject.Find("KartYeri9").GetComponent<SpriteRenderer>().sprite = kartlar[index9];
                eldekikartlar.Add(kartlar[index9].name);
                kartlar.RemoveAt(index9);
                

            }
            if (tıklamasayısı == 2)
            {
                int index10 = Random.Range(0, kartlar.Count);
                GameObject.Find("KartYeri10").GetComponent<SpriteRenderer>().sprite = kartlar[index10];
                eldekikartlar.Add(kartlar[index10].name);
                kartlar.RemoveAt(index10);
                
            }
            if (tıklamasayısı == 3)
            {
                int index11 = Random.Range(0, kartlar.Count);
                GameObject.Find("KartYeri11").GetComponent<SpriteRenderer>().sprite = kartlar[index11];
                eldekikartlar.Add(kartlar[index11].name);
                kartlar.RemoveAt(index11);
                
            }
            if (tıklamasayısı == 4)
            {
                int index12 = Random.Range(0, kartlar.Count);
                GameObject.Find("KartYeri12").GetComponent<SpriteRenderer>().sprite = kartlar[index12];
                eldekikartlar.Add(kartlar[index12].name);
                kartlar.RemoveAt(index12);
                
            }
            if (tıklamasayısı == 5)
            {
                int index13 = Random.Range(0, kartlar.Count);
                GameObject.Find("KartYeri13").GetComponent<SpriteRenderer>().sprite = kartlar[index13];
                eldekikartlar.Add(kartlar[index13].name);
                kartlar.RemoveAt(index13);
               
            }
            if (tıklamasayısı == 6)
            {
                int index14 = Random.Range(0, kartlar.Count);
                GameObject.Find("KartYeri14").GetComponent<SpriteRenderer>().sprite = kartlar[index14];
                eldekikartlar.Add(kartlar[index14].name);
                kartlar.RemoveAt(index14);
               
            }
            if (tıklamasayısı == 7)
            {
                int index15 = Random.Range(0, kartlar.Count);
                GameObject.Find("KartYeri15").GetComponent<SpriteRenderer>().sprite = kartlar[index15];
                eldekikartlar.Add(kartlar[index15].name);
                kartlar.RemoveAt(index15);
                
            }
            if (tıklamasayısı == 8)
            {
                int index16 = Random.Range(0, kartlar.Count);
                GameObject.Find("KartYeri16").GetComponent<SpriteRenderer>().sprite = kartlar[index16];
                eldekikartlar.Add(kartlar[index16].name);
                kartlar.RemoveAt(index16);
                

            }

        }


        tıklamasayısı++;
        
    }
    
    IEnumerator BotKartAt()
    {
        if (round == 1 && sıraKimde == 1)
        {
            int sayaç = 0;
            if (KartAtıldıMıBak() == true)
            {
                yield return new WaitForSeconds(2);


                for (int i = 0; i < bot1.Count; i++)
                {
                    GameObject.FindGameObjectWithTag("oksag").transform.localScale = new Vector3(1, 1, 1);
                    sayaç++;

                    if (((GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(0, 9)) == (bot1[i].name.Substring(0, 9)) && (bot1[i].name != "cardClubsA") && (bot1[i].name != "cardClubs10") && (bot1[i].name != "cardClubsJ") && (bot1[i].name != "cardClubs7")))
                    {
                        if (counter == 0)
                        {


                            GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite = bot1[i];
                            yerdekikartlar.Add(bot1[i]);
                            bot1.Remove(bot1[i]);
                            bot1kartattıMı = true;
                            counter++;

                        }

                    }
                    print("SAYAAAAAÇ= " + sayaç);

                    if (bot1kartattıMı == false && sayaç >= bot1.Count)
                    {
                        int bot1Sayı = Random.Range(0, kartlar.Count);
                        bot1.Add(kartlar[bot1Sayı]);
                        kartlar.RemoveAt(bot1Sayı);
                    }


                }

                if (counter == 0)
                {
                    counter++;
                }
                sıraKimde = 2;

            }

        }
        if (round == 1 && sıraKimde == 2)
        {
            int sayaç = 0;
            if (KartAtıldıMıBak() == true)
            {
                yield return new WaitForSeconds(2);


                for (int i = 0; i < bot2.Count; i++)
                {
                    GameObject.FindGameObjectWithTag("okorta").transform.localScale = new Vector3(1, 1, 1);
                    GameObject.FindGameObjectWithTag("oksag").transform.localScale = new Vector3(0, 0, 0);
                    sayaç++;
                    if (GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(0, 9) == bot2[i].name.Substring(0, 9) && bot2[i].name != "cardClubsA" && bot2[i].name != "cardClubs10" && bot2[i].name != "cardClubsJ" && bot2[i].name != "cardClubs7")
                    {

                        if (counter == 1)
                        {

                            GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite = bot2[i];
                            yerdekikartlar.Add(bot2[i]);
                            bot2.Remove(bot2[i]);
                            bot2kartattıMı = true;
                            counter++;
                        }

                    }
                    if (bot2kartattıMı == false && sayaç >= bot2.Count)
                    {
                        int bot2Sayı = Random.Range(0, kartlar.Count);
                        bot2.Add(kartlar[bot2Sayı]);
                        kartlar.RemoveAt(bot2Sayı);
                    }

                }
                if (counter == 1)
                {
                    counter++;
                }
                sıraKimde = 3;
            }
          
        }
        if (round == 1 && sıraKimde == 3)
        {
            int sayaç = 0;
            if (KartAtıldıMıBak() == true)
            {
                yield return new WaitForSeconds(2);


                for (int i = 0; i < bot3.Count; i++)
                {
                    GameObject.FindGameObjectWithTag("oksol").transform.localScale = new Vector3(1, 1, 1);
                    GameObject.FindGameObjectWithTag("okorta").transform.localScale = new Vector3(0, 0, 0);
                    sayaç++;
                    
                    if (GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(0, 9) == bot3[i].name.Substring(0, 9) && bot3[i].name != "cardClubsA" && bot3[i].name != "cardClubs10" && bot3[i].name != "cardClubsJ" && bot3[i].name != "cardClubs7")
                    {

                        if (counter == 2)
                        {

                            GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite = bot3[i];
                            yerdekikartlar.Add(bot3[i]);
                            bot3.Remove(bot3[i]);
                            bot3kartattıMı = true;
                            counter++;
                        }

                    }
                    if (bot3kartattıMı == false && sayaç >= bot3.Count)
                    {
                        int bot3Sayı = Random.Range(0, kartlar.Count);
                        bot3.Add(kartlar[bot3Sayı]);
                        kartlar.RemoveAt(bot3Sayı);
                        
                    }
                    
                }

                
            }
           
        }
      
        GameObject.FindGameObjectWithTag("oksol").transform.localScale = new Vector3(0, 0, 0);
        round = 2;
        sıraKimde = 1;
        eldekikartlar.Remove("kart atıldı");
        KartAtıldıMıBak();
        //akış true
        /*

        //akış true
        */
        //deneme 
        if (akış == true)
        {
            print(Joker.club +"club"+ Joker.diamond +"diamond"+ Joker.heart +"heart"+ Joker.spade+"spade");
            print(kac7 + "bu kadar yedi");
            if (round == 2 && sıraKimde == 1)
            {
                //GameObject.FindGameObjectWithTag("oksol").transform.localScale = new Vector3(0, 0, 0);
                GameObject.FindGameObjectWithTag("oksag").transform.localScale = new Vector3(1, 1, 1);
                if (Yoket.kartAttıMı == true)
                {

                    print(Joker.club + "club" + Joker.diamond + "diamond" + Joker.heart + "heart" + Joker.spade + "spade");
                    yield return new WaitForSeconds(2);

                    for (int i = 0; i < bot1.Count;i++)
                    {
                       if(Joker.club==true||Joker.spade==true||Joker.heart==true||Joker.diamond==true)
                        {
                            if(Joker.club==true)
                            {

                                if (bot1[i].name.Substring(4, 1) == "C")
                                {
                                    kartVarMı = true;
                                    GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite = bot1[i];
                                  //  yerdekikartlar.Add(bot1[i]);
                                    kac7=0;
                                    bot1.Remove(bot1[i]);
                                    break;
                                }
                                else
                                {
                                    kartVarMı = false;
                                }
                            }
                            if (Joker.spade==true)
                            {
                                if (bot1[i].name.Substring(4, 1) == "S")
                                {
                                    kartVarMı = true;
                                    GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite = bot1[i];
                                   // yerdekikartlar.Add(bot1[i]);
                                    kac7 = 0;
                                    bot1.Remove(bot1[i]);
                                    break;
                                }
                                else
                                {
                                    kartVarMı = false;
                                }
                            }
                            if (Joker.heart==true)
                            {
                                if (bot1[i].name.Substring(4, 1) == "H")
                                {
                                    kartVarMı = true;
                                    GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite = bot1[i];
                                   // yerdekikartlar.Add(bot1[i]);
                                    kac7 = 0;
                                    bot1.Remove(bot1[i]);
                                    break;
                                }
                                else
                                {
                                    kartVarMı = false;
                                }
                            }
                            if (Joker.diamond==true)
                            {
                                if (bot1[i].name.Substring(4, 1) == "D")
                                {
                                    kartVarMı = true;
                                    GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite = bot1[i];
                                 //   yerdekikartlar.Add(bot1[i]);
                                    kac7 = 0;
                                    bot1.Remove(bot1[i]);
                                    break;
                                }
                                else
                                {
                                    kartVarMı = false;
                                }
                            }
                        }
                        if (GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Length - 1) == "7"&& GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Length - 1) != "J")
                        {
                           


                                if (bot1[i].name.Substring(bot1[i].name.Length - 1) == "7")
                                {
                                    kartVarMı = true;
                                    GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite = bot1[i];
                                    yerdekikartlar.Add(bot1[i]);
                                    kac7++;
                                    bot1.Remove(bot1[i]);
                                    break;
                                }
                            
                            else
                            {
                                kartVarMı = false;
                                

                            }


                        }
                        if ((GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Length - 1) == bot1[i].name.Substring(bot1[i].name.Length - 1)) || (GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(4, 5) == bot1[i].name.Substring(4, 5)) && GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Length - 1) != "7"&& GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Length - 1) != "J")
                        {


                            //silebilisin
                            kartVarMı = true;
                            GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite = bot1[i];
                            yerdekikartlar.Add(bot1[i]);

                            bot1.Remove(bot1[i]);
                            break;

                        }

                        else
                        {
                            kartVarMı = false;
                        }



                    }
                    if (kartVarMı == false)
                    {

                        bot1.Add(kartlar[0]);
                        kartlar.RemoveAt(0);
                        print("bot 1 desteden kart çekti");
                        if ((GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Length - 1) == bot1[bot1.Count - 1].name.Substring(bot1[bot1.Count - 1].name.Length - 1)) || (GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(4, 5) == bot1[bot1.Count - 1].name.Substring(4, 5)) && GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Length - 1) != "7")
                        {
                            kartVarMı = true;
                            GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite = bot1[bot1.Count - 1];
                            yerdekikartlar.Add(bot1[bot1.Count - 1]);
                            bot1.Remove(bot1[bot1.Count - 1]);
                        }
                        //sil
                        if (GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Length - 1) == "7")
                        {
                            print(kac7 + "YEDİ SAYISI");
                            for (int x = 1; x < kac7 * 3; x++)
                            {
                                bot1.Add(kartlar[0]);
                                kartlar.RemoveAt(0);

                            }
                            kac7 = 0;
                        }
                        //sil






                    }
                }
                sıraKimde = 2;

            }
            if (round == 2 && sıraKimde == 2)
            {
                print(kac7 + "bu kadar yedi");
                GameObject.FindGameObjectWithTag("okorta").transform.localScale = new Vector3(1, 1, 1);
                GameObject.FindGameObjectWithTag("oksag").transform.localScale = new Vector3(0, 0, 0);
                if (Yoket.kartAttıMı == true)
                {


                    yield return new WaitForSeconds(2);

                    for (int i = 0; i < bot2.Count; i++)
                    {

                        if (GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Length - 1) == "7")
                        {



                            if (bot2[i].name.Substring(bot2[i].name.Length - 1) == "7")
                            {
                                kartVarMı = true;
                                GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite = bot2[i];
                                yerdekikartlar.Add(bot2[i]);
                                kac7++;
                                bot2.Remove(bot2[i]);
                                break;
                            }

                            else
                            {
                                kartVarMı = false;


                            }


                        }
                        if ((GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Length - 1) == bot2[i].name.Substring(bot2[i].name.Length - 1)) || (GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(4, 5) == bot2[i].name.Substring(4, 5)) && GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Length - 1) != "7")
                        {



                            kartVarMı = true;
                            GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite = bot2[i];
                            yerdekikartlar.Add(bot2[i]);

                            bot2.Remove(bot2[i]);

                            break;


                        }

                        else
                        {
                            kartVarMı = false;
                        }
                    }

                    if (kartVarMı == false)
                    {

                        bot2.Add(kartlar[0]);
                        kartlar.RemoveAt(0);
                        print("bot 2 desteden kart çekti");
                        if ((GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Length - 1) == bot2[bot2.Count - 1].name.Substring(bot2[bot2.Count - 1].name.Length - 1)) || (GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(4, 5) == bot2[bot2.Count - 1].name.Substring(4, 5)) && GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Length - 1) != "7")
                        {
                            kartVarMı = true;
                            GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite = bot2[bot2.Count - 1];
                            yerdekikartlar.Add(bot2[bot2.Count - 1]);
                            bot2.Remove(bot2[bot2.Count - 1]);
                        }
                        //sil
                        if (GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Length - 1) == "7")
                        {
                            print(kac7 + "YEDİ SAYISI");
                            for (int x = 1; x < kac7 * 3; x++)
                            {
                                bot2.Add(kartlar[0]);
                                kartlar.RemoveAt(0);

                            }
                            kac7 = 0;
                        }
                        //sil

                    }
                }

                sıraKimde = 3;

            }
            if (round == 2 && sıraKimde == 3)
            {
                print(kac7 + "bu kadar yedi");
                GameObject.FindGameObjectWithTag("oksol").transform.localScale = new Vector3(1, 1, 1);
                GameObject.FindGameObjectWithTag("okorta").transform.localScale = new Vector3(0, 0, 0);
                if (Yoket.kartAttıMı == true)
                {


                    yield return new WaitForSeconds(2);

                    for (int i = 0; i < bot3.Count; i++)
                    {
                        if (GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Length - 1) == "7")
                        {



                            if (bot3[i].name.Substring(bot3[i].name.Length - 1) == "7")
                            {
                                kartVarMı = true;
                                GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite = bot3[i];
                                yerdekikartlar.Add(bot3[i]);
                                kac7++;
                                bot3.Remove(bot3[i]);
                                break;
                            }

                            else
                            {
                                kartVarMı = false;


                            }


                        }
                        if ((GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Length - 1) == bot3[i].name.Substring(bot3[i].name.Length - 1)) || (GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(4, 5) == bot3[i].name.Substring(4, 5)) && GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Length - 1) != "7")
                        {


                            kartVarMı = true;
                            GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite = bot3[i];
                            yerdekikartlar.Add(bot3[i]);
                            bot3.Remove(bot3[i]);

                            eldekikartlar.Remove("kart atıldı");
                            break;




                        }


                        else
                        {
                            kartVarMı = false;
                        }

                    }
                    if (kartVarMı == false)
                    {

                        bot3.Add(kartlar[0]);
                        kartlar.RemoveAt(0);
                        print("bot 3 desteden kart çekti");
                        if ((GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Length - 1) == bot3[bot3.Count - 1].name.Substring(bot3[bot3.Count - 1].name.Length - 1)) || (GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(4, 5) == bot3[bot3.Count - 1].name.Substring(4, 5)) && GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Length - 1) != "7")
                        {
                            kartVarMı = true;
                            GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite = bot3[bot3.Count - 1];
                            yerdekikartlar.Add(bot3[bot3.Count - 1]);
                            bot3.Remove(bot3[bot3.Count - 1]);
                        }
                        //sil
                        if (GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Length - 1) == "7")
                        {
                            print(kac7 + "YEDİ SAYISI");
                            for (int x = 1; x < kac7 * 3; x++)
                            {
                                bot3.Add(kartlar[0]);
                                kartlar.RemoveAt(0);

                            }
                            kac7 = 0;
                        }
                        //sil
                    }



                    GameObject.FindGameObjectWithTag("oksol").transform.localScale = new Vector3(0, 0, 0);
                }
                print(kac7 + "bu kadar yedi");
                sıraKimde = 0;
                Yoket.kartAttıMı = false;
            }


        }
        //deneme
        if (akış == false)
        {
            sıraKimde = 3;
            print(sıraKimde + "!!!!!!!!!!!!!!!!!!!!!!");
            if (round == 2 && sıraKimde == 3)
            {
                GameObject.FindGameObjectWithTag("oksol").transform.localScale = new Vector3(1, 1, 1);
                GameObject.FindGameObjectWithTag("okorta").transform.localScale = new Vector3(0, 0, 0);
                if (Yoket.kartAttıMı == true)
                {


                    yield return new WaitForSeconds(2);

                    for (int i = 0; i < bot3.Count; i++)
                    {
                        if ((GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Length - 1) == bot3[i].name.Substring(bot3[i].name.Length - 1)) || (GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(4, 5) == bot3[i].name.Substring(4, 5)))
                        {


                            kartVarMı = true;
                            GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite = bot3[i];
                            yerdekikartlar.Add(bot3[i]);
                            bot3.Remove(bot3[i]);

                            eldekikartlar.Remove("kart atıldı");
                            break;



                        }
                        else
                        {
                            kartVarMı = false;
                        }

                    }
                    if (kartVarMı == false)
                    {
                        bot3.Add(kartlar[0]);
                        kartlar.RemoveAt(0);
                        print("bot 3 kart çekti");
                        if ((GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Length - 1) == bot3[bot3.Count - 1].name.Substring(bot3[bot3.Count - 1].name.Length - 1)) || (GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(4, 5) == bot3[bot3.Count - 1].name.Substring(4, 5)))
                        {
                            kartVarMı = true;
                            GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite = bot3[bot3.Count - 1];
                            yerdekikartlar.Add(bot3[bot3.Count - 1]);
                            bot3.Remove(bot3[bot3.Count - 1]);
                        }

                    }
                    GameObject.FindGameObjectWithTag("oksol").transform.localScale = new Vector3(0, 0, 0);
                }

                sıraKimde = 2;
                


            }
          
            if (round == 2 && sıraKimde == 2)
            {
                GameObject.FindGameObjectWithTag("okorta").transform.localScale = new Vector3(1, 1, 1);
                GameObject.FindGameObjectWithTag("oksol").transform.localScale = new Vector3(0, 0, 0);
                if (Yoket.kartAttıMı == true)
                {


                    yield return new WaitForSeconds(2);

                    for (int i = 0; i < bot2.Count; i++)
                    {
                        if ((GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Length - 1) == bot2[i].name.Substring(bot2[i].name.Length - 1)) || (GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(4, 5) == bot2[i].name.Substring(4, 5)) )
                        {

                            kartVarMı = true;
                            GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite = bot2[i];
                            yerdekikartlar.Add(bot2[i]);
                            bot2.Remove(bot2[i]);
                          
                            break;

                        }
                        else
                        {
                            kartVarMı = false;
                        }
                    }

                    if (kartVarMı == false)
                    {
                        bot2.Add(kartlar[0]);
                        kartlar.RemoveAt(0);
                        print("bot 2 kart çekti");
                        if ((GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Length - 1) == bot2[bot2.Count - 1].name.Substring(bot2[bot2.Count - 1].name.Length - 1)) || (GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(4, 5) == bot2[bot2.Count - 1].name.Substring(4, 5)))
                        {
                            kartVarMı = true;
                            GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite = bot2[bot2.Count - 1];
                            yerdekikartlar.Add(bot2[bot2.Count - 1]);
                            bot2.Remove(bot2[bot2.Count - 1]);
                        }
                    }


                }
                sıraKimde = 1;
                
            }
            if (round == 2 && sıraKimde == 1)
            {
                GameObject.FindGameObjectWithTag("okorta").transform.localScale = new Vector3(0, 0, 0);
                GameObject.FindGameObjectWithTag("oksag").transform.localScale = new Vector3(1, 1, 1);
                if (Yoket.kartAttıMı == true)
                {


                    yield return new WaitForSeconds(2);

                    for (int i = 0; i < bot1.Count; i++)
                    {
                        if ((GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Length - 1) == bot1[i].name.Substring(bot1[i].name.Length - 1)) || (GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(4, 5) == bot1[i].name.Substring(4, 5)) )
                        {


                            kartVarMı = true;
                            GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite = bot1[i];
                            yerdekikartlar.Add(bot1[i]);
                            bot1.Remove(bot1[i]);
                            

                            break;

                        }

                        else
                        {
                            kartVarMı = false;
                        }



                    }
                    if (kartVarMı == false)
                    {
                        bot1.Add(kartlar[0]);
                        kartlar.RemoveAt(0);
                        print("bot 1 kart çekti");
                        if ((GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Length - 1) == bot1[bot1.Count - 1].name.Substring(bot1[bot1.Count - 1].name.Length - 1)) || (GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite.name.Substring(4, 5) == bot1[bot1.Count - 1].name.Substring(4, 5)))
                        {
                            kartVarMı = true;
                            GameObject.Find("Masanın ortası").GetComponent<SpriteRenderer>().sprite = bot1[bot1.Count - 1];
                            yerdekikartlar.Add(bot1[bot1.Count - 1]);
                            bot1.Remove(bot1[bot1.Count - 1]);
                        }
                    }

                }
                sıraKimde = 0;
                Yoket.kartAttıMı = false;
               
                GameObject.FindGameObjectWithTag("oksag").transform.localScale = new Vector3(0, 0, 0);
            }

        }



    }
    void Update()
    {

        




        desteYönet();
        if (KartAtıldıMıBak() == true)
        {
            StartCoroutine(BotKartAt());
        }
    }

    public bool KartAtıldıMıBak()
    {
        for (int i = 0; i < eldekikartlar.Count; i++)
        {
            if (eldekikartlar.Contains("kart atıldı"))
            {
                return true;
            }

        }
        return false;
    }
    public bool yediVarMı()
    {
        for (int i = 0; i < eldekikartlar.Count; i++)
        {
            if (eldekikartlar.Contains("cardClubs7") || eldekikartlar.Contains("cardDiamonds7") || eldekikartlar.Contains("cardHearts7") || eldekikartlar.Contains("cardSpades7"))
            {
                return true;
            }

        }
        return false;
    }
    public bool onVarMı()
    {
        for (int i = 0; i < eldekikartlar.Count; i++)
        {
            if (eldekikartlar.Contains("cardClubs10") || eldekikartlar.Contains("cardDiamonds10") || eldekikartlar.Contains("cardHearts10") || eldekikartlar.Contains("cardSpades10"))
            {
                return true;
            }

        }
        return false;
    }
    public bool asVarMı()
    {
        for (int i = 0; i < eldekikartlar.Count; i++)
        {
            if (eldekikartlar.Contains("cardClubsA") || eldekikartlar.Contains("cardDiamondsA") || eldekikartlar.Contains("cardHeartsA") || eldekikartlar.Contains("cardSpadesA"))
            {
                return true;
            }

        }
        return false;
    }
    public bool valeVarMı()
    {
        for (int i = 0; i < eldekikartlar.Count; i++)
        {
            if (eldekikartlar.Contains("cardClubsJ") || eldekikartlar.Contains("cardDiamondsJ") || eldekikartlar.Contains("cardHeartsJ") || eldekikartlar.Contains("cardSpadesJ"))
            {
                return true;
            }

        }
        return false;
    }
    public void desteYönet()
    {
        if (kartlar.Count == 0)
        {
            for (int i = 0; i < yerdekikartlar.Count; i++)
            {
                kartlar.Add(yerdekikartlar[i]);
            }
        }
    }


   
}



















