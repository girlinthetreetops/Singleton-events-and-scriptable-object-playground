using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "User Data", menuName = "DataContainer/User")]

public class UserData : ScriptableObject
{
    [SerializeField] private string userName;
}
