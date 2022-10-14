using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Soal", menuName = "Scriptable Objects/Soal")]
public class SoalSO : ScriptableObject
{
    public string question;
    public int level;
    public string answer;
    public int priceLoot;
}
