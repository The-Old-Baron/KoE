using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Year", menuName = "Calendar/Year")]
public class Year : ScriptableObject
{
    public int year;
    public List<Month> months;
    public List<Season> seasons;
}