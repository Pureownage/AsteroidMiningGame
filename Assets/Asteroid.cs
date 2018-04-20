using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Asteroid : ScriptableObject {

    //ScriptableObject. This is used for the asteroid classes.

    public new string name;
    public string description;
    public int materialAmmount;
    public float miningDifficulty;
}