using System;
using UnityEngine;
using UnityEngine.Localization;

//[CreateAssetMenu(fileName = "New Card", menuName = "Mysterious_Cards/Card/CardData")]
public class CardData_SO : ScriptableObject
{
    // 稳定标识，不参与翻译。
    [SerializeField]
    private string cardId = "";
    
    // 规则属性，不随语言改变。
    [SerializeField]
    private CardRarity cardRarity = CardRarity.Standard;
    
    // 玩家看到的文字，引用本地化表。
    [SerializeField]
    private LocalizedString cardName = new();
    [SerializeField]
    private LocalizedString description = new();
    [SerializeField]
    private CardAffiliation cardAffiliation;
    
    public string CardId => cardId;
    public LocalizedString CardName => cardName;
    public LocalizedString Description => description;
    public CardAffiliation CardAffiliation => cardAffiliation;
    public CardRarity CardRarity => cardRarity;
}


[Serializable]
public struct CardAffiliation
{
    [SerializeField]
    private CardAffiliationType type;

    [SerializeField]
    private PathwayType pathway;

    public CardAffiliationType Type => type;
    public PathwayType Pathway => pathway;

    public bool IsNeutral => type == CardAffiliationType.Neutral;

    public bool IsValid =>
        (type == CardAffiliationType.Neutral
         && pathway == PathwayType.None)
        ||
        (type == CardAffiliationType.Pathway
         && pathway != PathwayType.None
         && Enum.IsDefined(typeof(PathwayType), pathway));
}