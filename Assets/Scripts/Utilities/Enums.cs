#region Cards
public enum CardType
{
    Unit = 0, Building = 1, Location = 2, Event = 3, Story = 4, Item = 5
}

public enum CreatureType
{
    Unspecified = 0, // 尚未配置，不是一种有效生物类别

    Human = 1,      // 人类
    Beast = 2,      // 野兽
    Plant = 3,      // 植物

    Undead = 4,     // 不死生物
    Spirit = 5,     // 灵体
    Wraith = 6,     // 怨魂

    Construct = 7   // 构装体／人工造物
}
public enum ItemType
{
    SealArtifact = 0, Consumable = 1, Food = 2, Drink = 3
}

public enum CardRarity
{
    Standard = 0, Grade3 = 1, Grade2 = 2, Grade1 = 3, Grade0 = 4
}

public enum CardAffiliationType
{
    Unspecified = 0, // 尚未配置，不是合法的中立牌
    Neutral = 1,     // 中立牌
    Pathway = 2      // 途径牌，具体途径另存
}
#endregion

#region Sequence

public enum PathwayType
{
    None = 0,           // 未指定途径，不属于22条途径之一

    Fool = 1,           // 愚者
    Error = 2,          // 错误
    Door = 3,           // 门

    Visionary = 4,      // 空想家
    Sun = 5,            // 太阳
    Tyrant = 6,         // 暴君
    WhiteTower = 7,     // 白塔
    HangedMan = 8,      // 倒吊人

    Darkness = 9,       // 黑暗
    Death = 10,         // 死神
    TwilightGiant = 11, // 黄昏巨人

    RedPriest = 12,     // 红祭司
    Demoness = 13,      // 魔女

    Mother = 14,        // 母亲
    Moon = 15,          // 月亮

    Hermit = 16,        // 隐者
    Paragon = 17,       // 完美者

    WheelOfFortune = 18,// 命运之轮

    BlackEmperor = 19,  // 黑皇帝
    Justiciar = 20,     // 审判者

    Abyss = 21,         // 深渊
    Chained = 22        // 被缚者
}

public enum SequenceRank
{
    Sequence9 = 9,
    Sequence8 = 8,
    Sequence7 = 7,
    Sequence6 = 6,
    Sequence5 = 5,
    Sequence4 = 4,
    Sequence3 = 3,
    Sequence2 = 2,
    Sequence1 = 1,
    Sequence0 = 0
}

#endregion