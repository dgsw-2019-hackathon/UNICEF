using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStat : MonoBehaviour
{
	
	private static int money;//자본

	private static int work;//노동력

	private static float reputationLocal;//평판(현지)

	private static float reputationHome;//평판(본국)

	private static float loyal;//충성심

    private static int weekPay;//주급

    private static int maintenanceCost;//유지비

    private static int payment;//상납금

    private static int profit;//수입

    private static int spending;//지출


	public Slider loyalSlider;

	public Slider localSlider;

	public Slider homeSlider;

	public Text moneyText;

    public Text workText;

    private void Start()
	{
        Screen.SetResolution(800, 600,true);

		setMoney(5000);
		setWork(200);
		setReputationLocal(0.5f);
		setReputationHome(0.5f);
		setLoyal(0.5f);
        setWeekPay(1);
        setMaintenanceCost(200);
        setPayment(200 - (int)(200 * reputationHome));
        setProfit((int)(work * loyal * 30));
        setSpending(maintenanceCost + (weekPay*work) + payment);
	}

	public int getMoney()
	{
		return money;
	}

	public void setMoney(int value)
	{
		money = value;
		moneyText.text = value.ToString();
	}

	public int getWork()
	{
		return work;
	}

	public void setWork(int value)
	{
		work = value;
        workText.text = value.ToString();
	}

	public float getReputationLocal()
	{
		return reputationLocal;
	}

	public void setReputationLocal(float value)
	{
		reputationLocal = value;
		localSlider.value = value;
	}

	public float getReputationHome()
	{
		return reputationHome;
	}

	public void setReputationHome(float value)
	{
		reputationHome = value;
		homeSlider.value = value;
	}

	public float getLoyal()
	{
		return loyal;
	}

	public void setLoyal(float value)
	{
		loyal = value;
		loyalSlider.value = value;
	}
    public int getWeekPay()
    {
        return weekPay;
    }

    public void setWeekPay(int value)
    {
        weekPay = value;
    }

    public int getMaintenanceCost()
    {
        return maintenanceCost;
    }

    public void setMaintenanceCost(int value)
    {
        maintenanceCost = value;
    }

    public int getPayment()
    {
        return payment;
    }

    public void setPayment(int value)
    {
        payment = value;
    }

    public int getprofit()
    {
        return profit;
    }

    public void setProfit(int value)
    {
        profit = value;
    }

    public int getSpending()
    {
        return spending;
    }

    public void setSpending(int value)
    {
        spending = value;
    }
}
