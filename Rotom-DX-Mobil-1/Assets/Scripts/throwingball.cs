using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwingball : MonoBehaviour
{
    public Rigidbody2D topRigidbody;
    public float maxGuc = 10f;
    public float geriCekilenMesafe = 2f;
    public GameObject okGameObject;
    private Vector2 baslangicNoktasi;
    private Vector2 sonNokta;
    private float guc;
    private bool firlatildi = false;

    void Start()
    {
        baslangicNoktasi = transform.position;
    }

    void Update()
    {
        if (!firlatildi)
        {
            if (Input.GetMouseButtonDown(0))
            {
                baslangicNoktasi = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }

            if (Input.GetMouseButton(0))
            {
                sonNokta = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                geriCekilenMesafe = Vector2.Distance(baslangicNoktasi, sonNokta);

                guc = Mathf.Clamp(geriCekilenMesafe, 0f, maxGuc);


                float okOlcek = geriCekilenMesafe / maxGuc;
                okGameObject.transform.localScale = new Vector3(1f, okOlcek + 1, 1f);
                float aci = Mathf.Atan2(baslangicNoktasi.y - sonNokta.y, baslangicNoktasi.x - sonNokta.x) * Mathf.Rad2Deg - 90;
                okGameObject.transform.rotation = Quaternion.Euler(0f, 0f, aci);

            }

            if (Input.GetMouseButtonUp(0))
            {
                Firlat();
            }
        }
    }

    void Firlat()
    {
        Vector2 firlatYonu = (baslangicNoktasi - sonNokta).normalized;
        topRigidbody.AddForce(firlatYonu * guc * 15, ForceMode2D.Impulse);
        Destroy(okGameObject);
        firlatildi = true;
    }
}

