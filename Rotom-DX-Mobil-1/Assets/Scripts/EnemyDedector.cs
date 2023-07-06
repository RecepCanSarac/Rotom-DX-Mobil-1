using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDedector : MonoBehaviour
{
    public List<GameObject> dusmanlar; // D��manlar� tutacak liste

    private void Start()
    {
        dusmanlar = new List<GameObject>();

        // Kameran�n i�erisindeki t�m d��manlar� al
        GameObject[] dusmanlarDizisi = GameObject.FindGameObjectsWithTag("Enemy");
        dusmanlar.AddRange(dusmanlarDizisi);
    }

    public void DusmanOldu(GameObject dusman)
    {
        // D��man� listeden sil
        dusmanlar.Remove(dusman);
    }
   
}
