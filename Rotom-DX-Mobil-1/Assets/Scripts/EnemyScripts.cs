using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScripts : MonoBehaviour
{
    [SerializeField] EnemyData _enemyData;
    public int health;
    private bool Special;
    public bool die;
    public int spacialNum;

    private UpgradeData _upgradeData;
    private PlayerMove _playerMove;
    private PlayerManager _playerManager;
    private void Awake()
    {
        _upgradeData = GameObject.FindGameObjectWithTag("Player").GetComponent<UpgradeData>();
        _playerMove = GameObject.FindGameObjectWithTag("Player").GetComponent <PlayerMove>();
        _playerManager = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerManager>();
    }
    void Start()
    {
        health = _enemyData.Health;
        Special = _enemyData.special;
    }
    private void Update()
    {
        if (health <= 0)
        {
          
            if (Special)
            {
                if (_playerMove.prevNum == spacialNum)
                {
                    spacialNum = Random.Range(0, _playerMove.playerDatas.Length);
                    Instantiate(_playerMove.playerDatas[spacialNum].Upgardes, transform.position, Quaternion.identity);
                    
                }
                else
                {
                    _playerMove.prevNum = spacialNum;
                }
                Debug.Log(spacialNum);
            }
            OnDusmanOlum();
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            health--;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            health--;
        }
    }
    private void OnDusmanOlum()
    {
        EnemyDedector dusmanTespiti = FindObjectOfType<EnemyDedector>();
        if (dusmanTespiti != null && dusmanTespiti.dusmanlar.Contains(gameObject))
        {
            dusmanTespiti.DusmanOldu(gameObject);
        }
        Destroy(gameObject);
    }

}
