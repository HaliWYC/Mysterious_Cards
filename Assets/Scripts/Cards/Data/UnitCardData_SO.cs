using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New UnitCardData", menuName = "Mysterious_Cards/Card/UnitCardData")]
public class UnitCardData_SO : CardData_SO
{
    [SerializeField] private List<CreatureType> creatureTypes = new();

    // 只读接口，供界面等代码读取。
    public IReadOnlyList<CreatureType> CreatureTypes => creatureTypes;
    // 检查这张卡是否属于指定类别。
    public bool HasCreatureType(CreatureType type)
    {
        if (type == CreatureType.Unspecified)
            return false;

        return creatureTypes != null && creatureTypes.Contains(type);
    }
}
