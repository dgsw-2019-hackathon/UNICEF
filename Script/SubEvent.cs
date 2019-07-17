using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubEvent : MonoBehaviour
{
    GameStat stat;

    GameController controller;

    public AdviceManager advice;

    int subEventCount;

    private void Awake()
    {
        stat = GameObject.Find("Main Camera").GetComponent<GameStat>();
        controller = GameObject.Find("Main Camera").GetComponent<GameController>();
    }

    public void checkTrue()
    {
        subEventRun(true);
    }
    public void checkFalse()
    {
        subEventRun(false);
    }


    public void subEventRun(bool answer)
    {
        subEventCount = controller.subEvent;
        Debug.Log(subEventCount);
        switch (subEventCount)
        {
            case 1:
                subEvent1(answer);
                break;
            case 2:
                subEvent2(answer);
                break;
            case 3:
                subEvent3(answer);
                break;
            case 4:
                subEvent4(answer);
                break;
            case 5:
                subEvent5(answer);
                break;
            case 6:
                subEvent6(answer);
                break;
            case 7:
                subEvent7(answer);
                break;
            case 8:
                subEvent8(answer);
                break;
            case 9:
                subEvent9(answer);
                break;
            case 10:
                subEvent10(answer);
                break;
            case 11:
                subEvent11(answer);
                break;
            case 12:
                subEvent12(answer);
                break;
            case 13:
                subEvent13(answer);
                break;
            case 14:
                subEvent14(answer);
                break;
            case 15:
                subEvent15(answer);
                break;
            case 16:
                subEvent16(answer);
                break;
            case 17:
                subEvent17(answer);
                break;
            case 18:
                subEvent18(answer);
                break;
            case 19:
                subEvent19(answer);
                break;
            case 20:
                subEvent20(answer);
                break;
        }

        subEventCount = 0;
        controller.subEvent = 0;

        advice.deleteText();

        controller.subEventClear();
    }

    public void subEvent1(bool answer)
    {
        //string quset = "현지인 1 : 살려주세요! 백인들이 절 죽이려고해요";

        if(answer)
        {
            stat.setReputationLocal(stat.getReputationLocal() + 0.01f);
            stat.setMoney(stat.getMoney() - 20);
        }
        else
        {
            stat.setReputationLocal(stat.getReputationLocal() - 0.03f);
        }
    }

    public void subEvent2(bool answer)
    {
        //string quset = "현지인 2 : 현재 저희 마을이 많이 힘들어요. 지원을 해주시면 안될까요";

        if (answer)
        {
            stat.setReputationLocal(stat.getReputationLocal() + 0.03f);
            stat.setMoney(stat.getMoney() - 100);
        }
        else
        {
            stat.setReputationLocal(stat.getReputationLocal() - 0.03f);
        }
    }

    public void subEvent3(bool answer)
    {
        //string quset = "노동자 1 : 저희가 받는 임금이 너무 적어요. 주급을 인상해주세요";

        if (answer)
        {
            stat.setWeekPay(stat.getWeekPay() + 1);
            stat.setLoyal(stat.getLoyal() + 0.05f);
            stat.setReputationLocal(stat.getReputationLocal() + 0.02f);
        }
        else
        {
            stat.setLoyal(stat.getLoyal() - 0.05f);
            stat.setReputationLocal(stat.getReputationLocal() - 0.05f);
        }
    }

    public void subEvent4(bool answer)
    {
        //string quset = "노동자 2 : 더 좋은 기계가 있다면 공장의 효율이 늘어날 거예요. 장비를 확충해주세요";

        if (answer)
        {
            stat.setMaintenanceCost(stat.getMaintenanceCost() + 20);
            stat.setLoyal(stat.getLoyal() + 0.03f);
            stat.setReputationHome(stat.getReputationHome() - 0.01f);
        }
        else
        {
            stat.setLoyal(stat.getLoyal() - 0.04f);
        }
    }

    public void subEvent5(bool answer)
    {
        //string quset = "아이들 : 저희는 돈을 벌지 못하면 곧 굶어죽어요. 저희를 고용해 주세요";

        if (answer)
        {
            stat.setWork(stat.getWork() + 50);
            stat.setReputationLocal(stat.getReputationLocal() + 0.03f);
        }
        else
        {
            stat.setReputationLocal(stat.getReputationLocal() - 0.02f);
        }
    }

    public void subEvent6(bool answer)
    {
        //string quset = "상인 : 공장의 노동자들이 전부 아이들로 이루어있다고 알고있습니다. 이 장갑들이 있으면 아이들이 더 편히 작업을 할 수 있을겁니다";

        if (answer)
        {
            stat.setMoney(stat.getMoney() - 500);
            stat.setLoyal(stat.getLoyal() + 0.05f);
            stat.setReputationLocal(stat.getReputationLocal() + 0.03f);
        }
        else
        {

        }
    }

    public void subEvent7(bool answer)
    {
        //string quset = "현지인 3 : 공장에서 나오는 매연이 저희들의 일상을 해치고 있어요. 배상 해주셨음 해요";

        if (answer)
        {
            stat.setReputationLocal(stat.getReputationLocal() + 0.1f);
        }
        else
        {
            stat.setReputationLocal(stat.getReputationLocal() - 0.15f);
        }
    }

    public void subEvent8(bool answer)
    {
        //string quset = "봉사자 : 이 곳의 빈곤한 아이들을 위하여 모금 참여 부탁드립니다";

        if (answer)
        {
            stat.setMoney(stat.getMoney() - 10);
            stat.setReputationLocal(stat.getReputationLocal() + 0.01f);
        }
        else
        {
            stat.setReputationLocal(stat.getReputationLocal() - 0.03f);
        }
    }

    public void subEvent9(bool answer)
    {
        //string quset = "거지 : 너무 배고픕니다 한 푼만 주세요";

        if (answer)
        {
            stat.setMoney(stat.getMoney() - 5);
            stat.setReputationLocal(stat.getReputationLocal() + 0.01f);
        }
        else
        {
            stat.setReputationLocal(stat.getReputationLocal() + 0.05f);
        }
    }

    public void subEvent10(bool answer)
    {
        //string quset = "노동자 3 : 집에서 공장까지 출근하는 길이 너무 멀어요, 대책을 세워주세요";

        if (answer)
        {
            stat.setMoney(stat.getMoney() - (stat.getWork() * 20));
            stat.setLoyal(stat.getLoyal() + 0.1f);
        }
        else
        {
            stat.setLoyal(stat.getLoyal() + 0.05f);
            stat.setWork(stat.getWork() - 50);
        }
    }

    public void subEvent11(bool answer)
    {
        //string quset = "축하객 1 : 공장장으로 부임 하신 것을 축하 드립니다. 현지의 산업 발전에 기여 하시면 어떻겠습니까?";

        if (answer)
        {
            stat.setMoney(stat.getMoney() - 200);
            stat.setReputationLocal(stat.getReputationLocal() + 0.03f);
        }
        else
        {

        }
    }

    public void subEvent12(bool answer)
    {
        //string quset = "본사 파견인 1 : 본사에서 희토류 탐사에 관심을 돌리고 있는데... 이참에 윗분들 눈에도 들고..... 어떠십니까?";

        if (answer)
        {
            stat.setMoney(stat.getMoney() - 500);
            stat.setReputationHome(stat.getReputationHome() + 0.03f);
        }
        else
        {
            stat.setReputationHome(stat.getReputationHome() - 0.03f);
        }
    }

    public void subEvent13(bool answer)
    {
        //string quset = "정치인 1 : 전 앞으로 대선에 나가 대통령이 될 사람입니다. 저에게 투자 해보시면 어떻겠습니까?";

        if (answer)
        {
            stat.setMoney(stat.getMoney() - 500);
        }
        else
        {

        }
    }

    public void subEvent14(bool answer)
    {
        //string quset = "현지인 4 : 전 이 근처에 사는 현지인인데, 너무 시끄러워서 잠을 잘 수가 없어요";

        if (answer)
        {
            stat.setMaintenanceCost(stat.getMaintenanceCost() + 100);
            stat.setReputationLocal(stat.getReputationLocal() + 0.05f);
        }
        else
        {
            stat.setReputationLocal(stat.getReputationLocal() - 0.05f);
        }
    }

    public void subEvent15(bool answer)
    {
        //string quset = "본국 정치인 : 본국의 여왕님이 성대한 생일파티를 하십니다. 거대한 케이크를 보내도록 하죠";

        if (answer)
        {
            stat.setMoney(stat.getMoney() - 500);
            stat.setReputationHome(stat.getReputationHome() + 0.03f);
        }
        else
        {
            stat.setReputationHome(stat.getReputationHome() - 0.03f);
        }
    }

    public void subEvent16(bool answer)
    {
        //string quset = "이웃 공장장 1 : 옆 공장에서 핵을 만드는 것 같은데 같이 고발 하시는 것이 어떻겠습니까?";

        if (answer)
        {
            stat.setReputationLocal(stat.getReputationLocal() - 0.03f);
        }
        else
        {
            
        }
    }

    public void subEvent17(bool answer)
    {
        //string quset = "이웃 공장장 2 : 우리 같이 주급을 조작하여 인건비를 줄입시다";

        if (answer)
        {
            stat.setWeekPay(stat.getWeekPay() - 1);
            stat.setLoyal(stat.getLoyal() - 0.05f);
        }
        else
        {
            stat.setMoney(stat.getMoney() + 500);
        }
    }

    public void subEvent18(bool answer)
    {
        //string quset = "이웃 농장 주인 1 : 그쪽 노동자를 우리 농장에서 일하게 할 수는 없을까요? 1,000$를 드리겠습니다";

        if (answer)
        {
            stat.setWork(stat.getWork() - 100);
            stat.setMoney(stat.getMoney() + 1000);
        }
        else
        {
            stat.setReputationLocal(stat.getReputationLocal() - 0.03f);
        }
    }

    public void subEvent19(bool answer)
    {
        //string quset = "운동인 1 : 이 공장의 후원을 받아 운동 대회에 참가하고 싶습니다";

        if (answer)
        {
            stat.setMoney(stat.getMoney() - 1000);
            stat.setReputationLocal(stat.getReputationLocal() + 0.05f);
        }
        else
        {
            stat.setReputationLocal(stat.getReputationLocal() - 0.03f);
        }
    }

    public void subEvent20(bool answer)
    {
        //string quset = "음악인 1 : 이 공장 노동자들을 위하여 공연을 하고 싶습니다";

        if (answer)
        {
            stat.setMoney(stat.getMoney() - 500);
            stat.setLoyal(stat.getLoyal() + 0.05f);
        }
        else
        {
            stat.setReputationLocal(stat.getReputationLocal() - 0.03f);
        }
    }

}
