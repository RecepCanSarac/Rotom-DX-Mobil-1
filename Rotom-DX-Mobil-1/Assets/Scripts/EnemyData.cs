using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyType",menuName ="EnemyType")]
public class EnemyData : ScriptableObject
{
    public int Health;
    public bool special;
}
