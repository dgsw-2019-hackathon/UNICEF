using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event : MonoBehaviour
{
    GameStat stat;

    public GameObject evtPanel;
    public GameObject prol;
    public GameObject evt4;
    public GameObject evt5;
    public GameObject evt6;
    public GameObject evt7;
    public GameObject evt9;
    public GameObject evt12;

    private void Start()
    {
        stat = GameObject.Find("Main Camera").GetComponent<GameStat>();

        //prologue();
    }
    public void prologue()
    {
        evtPanel.SetActive(true);
        prol.SetActive(true);
    }

    public void prologueRun()
    {
        prol.SetActive(false);
        evtPanel.SetActive(false);
    }

    public void eventJanuary()//1월
    {
        
    }

    public void eventFebruary() {//2월
        
    }

    public void eventMarch() {//3월
        
    }

    public void eventEndApril() {//끝 4월
        
    }
    public void eventStartApril()//시작 4월
    {
        evtPanel.SetActive(true);
        evt4.SetActive(true);
    }

    public void eventStartApril_1()
    {
        stat.setMoney(stat.getMoney() - 2000);
        stat.setWork(stat.getWork() + 100);
        evtPanel.SetActive(false);
        evt4.SetActive(false);
    }
    public void eventStartApril_2()
    {
        stat.setMoney(stat.getMoney() - 2000);
        stat.setReputationHome(stat.getReputationHome() + 0.1f);
        evtPanel.SetActive(false);
        evt4.SetActive(false);
    }
    public void eventStartApril_3()
    {
        stat.setReputationHome(stat.getReputationHome() - 0.05f);
        evtPanel.SetActive(false);
        evt4.SetActive(false);
    }
    public void eventMay()//5월
    {
        evtPanel.SetActive(true);
        evt5.SetActive(true);
    }
    public void eventMay_1()
    {
        stat.setMaintenanceCost(stat.getMaintenanceCost() + 100);
        stat.setLoyal(stat.getLoyal() + 0.1f);
        evtPanel.SetActive(false);
        evt5.SetActive(false);
    }
    public void eventMay_2()
    {
        stat.setWeekPay(stat.getWeekPay() + 1);
        stat.setLoyal(stat.getLoyal() + 0.1f);
        evtPanel.SetActive(false);
        evt5.SetActive(false);
    }
    public void eventMay_3()
    {
        stat.setLoyal(stat.getLoyal() - 0.1f);
        evtPanel.SetActive(false);
        evt5.SetActive(false);
    }
    public void eventJune()//6월
    {
        
    }
    public void eventJuly()//7월
    {
        evtPanel.SetActive(true);
        evt7.SetActive(true);
    }
    public void eventJuly_1()
    {
        stat.setMoney(stat.getMoney() + 1000);
        stat.setReputationHome(stat.getReputationHome() + 0.05f);
        evtPanel.SetActive(false);
        evt7.SetActive(false);
    }
    public void eventJuly_2()
    {
        stat.setLoyal(stat.getLoyal() + 0.05f);
        evtPanel.SetActive(false);
        evt7.SetActive(false);
    }
    public void eventAugust()//8월
    {
        
    }
    public void eventSeptember()//9월
    {
        evtPanel.SetActive(true);
        evt9.SetActive(true);
    }
    public void eventSeptember_1()
    {
        stat.setReputationLocal(stat.getReputationLocal() + 0.15f);
        stat.setMoney(stat.getMoney() - 2000);
        evtPanel.SetActive(false);
        evt9.SetActive(false);
    }
    public void eventSeptember_2()
    {
        stat.setReputationLocal(stat.getReputationLocal() - 0.15f);
        stat.setMoney(stat.getMoney() + 2000);
        stat.setLoyal(stat.getLoyal() - 0.05f);
        evtPanel.SetActive(false);
        evt9.SetActive(false);
    }
    public void eventSeptember_3()
    {
        stat.setReputationLocal(stat.getReputationLocal() - 0.05f);
        evtPanel.SetActive(false);
        evt9.SetActive(false);
    }
    public void eventOctober()//10월
    {
        
    }

    public void eventNovember()//11월
    {
        
    }

    public void eventDecember()//12월
    {
        evtPanel.SetActive(true);
        evt12.SetActive(true);
    }
    public void eventDecember_1()
    {
        if(stat.getReputationHome() >= 0.8f)
        {
            stat.setMoney(stat.getMoney() + 2000);
        }
        else if(stat.getReputationHome() < 0.8f)
        {
            stat.setMaintenanceCost(stat.getMaintenanceCost() + 100);
        }

        if(stat.getWork() >= 1000)
        {
            stat.setMoney(stat.getMoney() + 5000);
        }
        else if(stat.getWork() < 1000)
        {

        }
        evtPanel.SetActive(false);
        evt9.SetActive(false);
    }
}
