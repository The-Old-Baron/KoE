using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Season", menuName = "Calendar/Season")]
public class Season : ScriptableObject
{
    public string seasonName;
    public List<Month> months;
}