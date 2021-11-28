using TMPro;
using UnityEngine;

public class CurrencyView : MonoBehaviour
{
    private const string CoinKey = nameof(CoinKey);
    private const string DiamondKey = nameof(DiamondKey);

    public static CurrencyView Instance { get; private set; }


    [SerializeField]
    private TMP_Text _currentCountCoin;

    [SerializeField]
    private TMP_Text _currentCountDiamond;

    private int Coins
    {
        get => PlayerPrefs.GetInt(CoinKey, 0);
        set => PlayerPrefs.SetInt(CoinKey, value);
    }

    private int Diamonds
    {
        get => PlayerPrefs.GetInt(DiamondKey, 0);
        set => PlayerPrefs.SetInt(DiamondKey, value);
    }

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    private void Start()
    {
        RefreshText();
    }

    public void AddCoins(int value)
    {
        Coins += value;
        RefreshText();
    }

    public void AddDiamonds(int value)
    {
        Diamonds += value;
        RefreshText();
    }

    private void RefreshText()
    {
        _currentCountCoin.text = Coins.ToString();
        _currentCountDiamond.text = Diamonds.ToString();
    }
}
