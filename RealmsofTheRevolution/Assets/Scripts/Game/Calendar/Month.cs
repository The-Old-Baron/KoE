using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Month", menuName = "Calendar/Month")]
public class Month : ScriptableObject
{
    public string monthName;
    public int monthNumber;
    public int daysInMonth;
    public List<Day> days;
}