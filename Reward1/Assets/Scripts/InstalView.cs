using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstalView : MonoBehaviour
{
    [SerializeField]
    private DailyRewardView _dailyRewardView;

    private DailyRewardController _dailyRewardController;

    private void Awake()
    {
        _dailyRewardController = new DailyRewardController(_dailyRewardView);
    }

    void Start()
    {
        _dailyRewardController.RefreshView();
    }

    
   
}
