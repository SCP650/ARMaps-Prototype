using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnScriptableObject", order = 1)]
public class SpawnScriptableObject : ScriptableObject
{
    public GameObject people;
    public GameObject table;
    public GameObject obstacle;
}