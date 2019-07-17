using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PolicyManager : MonoBehaviour
{
    private int max_toggle = 2; // 토글 활성화 최댓값
    private int currentToggle;

    private float magnifyReputationLocal;    // 변경될 평판(현지)의 배율
    private float magnifyReputationHomel;    // 변경될 평판(본사)의 배율
    private float magnifyLoyal;              // 변경될 충성심의 배율
    private int magnifyMaintenanceCost;    // 변경될 유지비의 배율
    private float magnifyProfit;             // 변경될 수입의 배율

    public PolicyToggle[] toggles;

    GameStat stat = new GameStat();

    void Start() // 초기화
    {
        
        init();
    }

    private void init() // 초기화
    {
        countToggle();

        magnifyReputationLocal = 1;
        magnifyReputationHomel = 1;
        magnifyLoyal = 1;
        magnifyMaintenanceCost = 1;
        magnifyProfit = 1;
    }

    public void ClickedToggle(int idx) // 토글이 클릭되었을 때 실행
    {
        countToggle();
        if(currentToggle <= max_toggle)
        {
            changeMagnify(toggles[idx]);
        }
        else if (currentToggle > max_toggle)
        {
            addMagnify(toggles[idx]);
            toggles[idx].toggle.isOn = false;
        }
    }
    public void ClickedToggleForLunch(int idx) // 토글이 클릭되었을 때 실행
    {
        countToggle();
        if (currentToggle <= max_toggle)
        {
            changeMagnify(toggles[idx]);
            changeLunchFreeMaintenance(toggles[idx]);
        }
        else if (currentToggle > max_toggle)
        {
            addMagnify(toggles[idx]);
            addLunchFreeMaintenance();
            toggles[idx].toggle.isOn = false;
        }
    }

    public void minusLunchFreeMaintenance()
    {
        magnifyMaintenanceCost -= stat.getWork();
    }

    public void addLunchFreeMaintenance()
    {
        magnifyMaintenanceCost += stat.getWork();
    }

    public void changeLunchFreeMaintenance(PolicyToggle toggle)
    {
        if (toggle.toggle.isOn)
        {
            addLunchFreeMaintenance();
        }
        else
        {
            minusLunchFreeMaintenance();
        }
    }

    private void changeMagnify(PolicyToggle toggle)
    {
        if(toggle.toggle.isOn)
        {
            addMagnify(toggle);
        }
        else
        {
            minusMagnify(toggle);
        }
    }

    private void addMagnify(PolicyToggle toggle) // 배율 증가
    {
        magnifyReputationLocal += toggle.magnifyReputationLocal;
        magnifyReputationHomel += toggle.magnifyReputationHomel;
        magnifyLoyal += toggle.magnifyLoyal;
        magnifyMaintenanceCost += toggle.magnifyMaintenanceCost;
        magnifyProfit += toggle.magnifyProfit;
        stat.setMoney(stat.getMoney() - toggle.useMoney);
    }
    private void minusMagnify(PolicyToggle toggle)
    {
        magnifyReputationLocal -= toggle.magnifyReputationLocal;
        magnifyReputationHomel -= toggle.magnifyReputationHomel;
        magnifyLoyal -= toggle.magnifyLoyal;
        magnifyMaintenanceCost -= toggle.magnifyMaintenanceCost;
        magnifyProfit -= toggle.magnifyProfit;
        stat.setMoney(stat.getMoney() + toggle.useMoney);
    }

    public void countToggle() // 현재 활성화 되어있는 토글의 수를 카운트
    {
        currentToggle = 0;

        for(int i = 0; i < toggles.Length; i++)
        {
            if(toggles[i].toggle.isOn)
            {
                currentToggle += 1;
            }
        }
    }

    public void changeCausePolicy()
    {
        stat.setReputationLocal(stat.getReputationLocal() * magnifyReputationLocal);
        stat.setReputationHome(stat.getReputationHome() * magnifyReputationHomel);
        stat.setLoyal(stat.getLoyal() * magnifyLoyal);
        stat.setMaintenanceCost((int)(stat.getMaintenanceCost() + magnifyMaintenanceCost));
        stat.setProfit((int)(stat.getprofit() * magnifyProfit));
    }
}
