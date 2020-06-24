using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Collider))]
public class Item : MonoBehaviour
{
    public EItemType type;
}
[System.Serializable]
public enum EItemType
{
    HEALTH_KIT,
    BOX,
}
