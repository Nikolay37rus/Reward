using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ContainerSlotRewardView : MonoBehaviour
{
    [SerializeField]
    private Image _selectBackground;

    [SerializeField]
    private Image _iconCurrency;

    [SerializeField]
    private TMP_Text _textDay;

    [SerializeField]
    private TMP_Text _countReward;

    public void SetData(Reward reward, int countDay, bool isSelect)
    {
        _iconCurrency.sprite = reward.IconCurrency;
        _textDay.text = $"Day{countDay}";
        _countReward.text = reward.CountCurrency.ToString();
        _selectBackground.gameObject.SetActive(isSelect);
    }

}
