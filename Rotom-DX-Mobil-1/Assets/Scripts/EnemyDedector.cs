using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDedector : MonoBehaviour
{
    public List<GameObject> dusmanlar; // Düþmanlarý tutacak liste

    private void Start()
    {
        dusmanlar = new List<GameObject>();

        // Kameranýn içerisindeki tüm düþmanlarý al
        GameObject[] dusmanlarDizisi = GameObject.FindGameObjectsWithTag("Enemy");
        dusmanlar.AddRange(dusmanlarDizisi);
    }

    public void DusmanOldu(GameObject dusman)
    {
        // Düþmaný listeden sil
        dusmanlar.Remove(dusman);
    }
   
}
