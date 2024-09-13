using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        IronMan ironMan = new IronMan("Tony Stark", 100, "Red");
        CaptainAmerica capthinAmerica = new CaptainAmerica("steve rogers", 100, "Bule");

        //ประกาศชื่อ,Hp,สี
        Debug.Log($"IronMan: name {ironMan.Name}, hp {ironMan.Hp}, color {ironMan.SuitColor}");
        Debug.Log($"CapthinAmerica: name {capthinAmerica.Name}, hp {capthinAmerica.Hp}, color {capthinAmerica.SuitColor}");

        //ผลัดกันโจมตี 5 รอบ
        for (int i = 1; i < 5; i++)
        {
            //ไอรอนแมนโจมตี
            ironMan.Fly();
            ironMan.ShootLeser();
            ironMan.UpdateArmorStrenght(5.25f);
            capthinAmerica.Takedamege(20);

            //กัปตันอเมริกาโจมตี
            capthinAmerica.LeapAndJump();
            capthinAmerica.ThrowShield();
            capthinAmerica.UpdateArmorStrenght(5.25f);
            ironMan.Takedamege(20);
        }
    }
}
