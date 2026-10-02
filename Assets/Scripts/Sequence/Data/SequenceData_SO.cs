using UnityEngine;
using UnityEngine.Localization;

[CreateAssetMenu(fileName = "SequenceDataSO", menuName = "Mysterious_Cards/Sequence/SequenceData")]
public class SequenceData_SO : ScriptableObject
{
    [SerializeField]
    private PathwayType pathway = PathwayType.None;

    [SerializeField]
    private SequenceRank rank = SequenceRank.Sequence9;

    [SerializeField]
    private LocalizedString sequenceName = new();

    public PathwayType Pathway => pathway;
    public SequenceRank Rank => rank;
    public LocalizedString SequenceName => sequenceName;
}
