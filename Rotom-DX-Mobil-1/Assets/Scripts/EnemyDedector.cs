using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDedector : MonoBehaviour
{
    public List<GameObject> dusmanlar;

    public GameObject nextLevelPanel;

    private void Start()
    {
        nextLevelPanel.SetActive(false);
        dusmanlar = new List<GameObject>();

        // Kameranýn içerisindeki tüm düþmanlarý al
        GameObject[] dusmanlarDizisi = GameObject.FindGameObjectsWithTag("Enemy");
        dusmanlar.AddRange(dusmanlarDizisi);
    }

    private void Update()
    {
        if (dusmanlar.Count == 0)
        {
            nextLevelPanel.SetActive(true);
        }
    }
    public void DusmanOldu(GameObject dusman)
    {
        // Düþmaný listeden sil
        dusmanlar.Remove(dusman);
    }
   
}
