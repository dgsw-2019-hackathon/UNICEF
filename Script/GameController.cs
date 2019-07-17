using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    int week;

    int month;

    public int subEvent;

    public Text weekText;

    public AdviceManager advice;

    public AdviceManager adviceCensor;

    Event evt;

    GameStat stat;

    void Start()
    {
        evt = GameObject.Find("Main Camera").GetComponent<Event>();
        stat = GameObject.Find("Main Camera").GetComponent<GameStat>();
        month = 3;
        week = 4;
        nextWeek();
    }

    public void nextWeek()
    {
        if (month >= 12 && week >= 4)
        {
            month = 1;
            week = 1;
        }
        else if(week >= 4)
        {
            month++;
            week = 1;
            stat.setProfit((int)(stat.getWork() * stat.getLoyal() * 30));
            checkEvent();
        }
        else
        {
            week++;
        }
        weekText.text = month.ToString() + "월 " + week.ToString() + "번째 주";

        stat.setMaintenanceCost(200 - (int)(200 * stat.getReputationHome()));

        stat.setMoney(stat.getMoney() - (stat.getWeekPay() * stat.getWork()));
        stat.setMoney(stat.getMoney() - (stat.getMaintenanceCost() + stat.getPayment()));
        subEvent = Random.Range(1, 20 + 1);
        subEventText();
        
    }

    public void checkEvent()
    {
            if(month == 1)
            {

            }
            else if(month == 2) {

            }
            else if (month == 3)
            {

            }
            else if (month == 4)
            {
            evt.eventStartApril();
            }
            else if (month == 5)
            {
            evt.eventMay();
        }
            else if (month == 6)
            {

            }
            else if (month == 7)
            {
            evt.eventJuly();
        }
            else if (month == 8)
            {

            }
            else if (month == 9)
            {
            evt.eventSeptember();
        }
            else if (month == 10)
            {

            }
            else if (month == 11)
            {

            }
            else if (month == 12)
            {
            evt.eventDecember();
        }
    }

    public void subEventClear()
    {
        advice.setWorkerText("");
        adviceCensor.setcensorText("");
    }

    void subEventText()
    {

        
        if (subEvent == 1)
        {
            advice.setWorkerText("현지인 1 : 살려주세요! 백인들이 절 죽이려고해요");
        }
        else if(subEvent == 2)
        {
            advice.setWorkerText("현지인 2 : 현재 저희 마을이 많이 힘들어요. 지원을 해주시면 안될까요");

        }
        else if (subEvent == 3)
        {
            advice.setWorkerText("노동자 1 : 저희가 받는 임금이 너무 적어요. 주급을 인상해주세요");
        }
        else if (subEvent == 4)
        {
            advice.setWorkerText("노동자 2 : 더 좋은 기계가 있다면 공장의 효율이 늘어날 거예요. 장비를 확충해주세요");
        }
        else if (subEvent == 5)
        {
            advice.setWorkerText("아이들 : 저희는 돈을 벌지 못하면 곧 굶어죽어요. 저희를 고용해 주세요");
        }
        else if (subEvent == 6)
        {
            adviceCensor.setcensorText("상인 : 공장의 노동자들이 전부 아이들로 이루어있다고 알고있습니다. 이 장갑들이 있으면 아이들이 더 편히 작업을 할 수 있을겁니다");
        }
        else if (subEvent == 7)
        {
            advice.setWorkerText("현지인 3 : 공장에서 나오는 매연이 저희들의 일상을 해치고 있어요. 배상 해주셨음 해요");
        }
        else if (subEvent == 8)
        {
            adviceCensor.setcensorText("봉사자 : 이 곳의 빈곤한 아이들을 위하여 모금 참여 부탁드립니다");
        }
        else if (subEvent == 9)
        {
            advice.setWorkerText("거지 : 너무 배고픕니다 한 푼만 주세요");
        }
        else if (subEvent == 10)
        {
            advice.setWorkerText("노동자 3 : 집에서 공장까지 출근하는 길이 너무 멀어요, 대책을 세워주세요");
        }
        else if (subEvent == 11)
        {
            adviceCensor.setcensorText("축하객 1 : 공장장으로 부임 하신 것을 축하 드립니다. 현지의 산업 발전에 기여 하시면 어떻겠습니까?");
        }
        else if (subEvent == 12)
        {
            adviceCensor.setcensorText("본사 파견인 1 : 본사에서 희토류 탐사에 관심을 돌리고 있는데... 이참에 윗분들 눈에도 들고..... 어떠십니까?");
        }
        else if (subEvent == 13)
        {
            adviceCensor.setcensorText("정치인 1 : 전 앞으로 대선에 나가 대통령이 될 사람입니다. 저에게 투자 해보시면 어떻겠습니까?");
        }
        else if (subEvent == 14)
        {
            advice.setWorkerText("현지인 4 : 전 이 근처에 사는 현지인인데, 너무 시끄러워서 잠을 잘 수가 없어요");
        }
        else if (subEvent == 15)
        {
            adviceCensor.setcensorText("본국 정치인 : 본국의 여왕님이 성대한 생일파티를 하십니다. 거대한 케이크를 보내도록 하죠");
        }
        else if (subEvent == 16)
        {
            adviceCensor.setcensorText("이웃 공장장 1 : 옆 공장에서 핵을 만드는 것 같은데 같이 고발 하시는 것이 어떻겠습니까?");
        }
        else if (subEvent == 17)
        {
            adviceCensor.setcensorText("이웃 공장장 2 : 우리 같이 주급을 조작하여 인건비를 줄입시다");
        }
        else if (subEvent == 18)
        {
            adviceCensor.setcensorText("이웃 농장 주인 1 : 그쪽 노동자를 우리 농장에서 일하게 할 수는 없을까요? 1,000$를 드리겠습니다");
        }
        else if (subEvent == 19)
        {
            adviceCensor.setcensorText("운동인 1 : 이 공장의 후원을 받아 운동 대회에 참가하고 싶습니다");
        }
        else
        {
            adviceCensor.setcensorText("음악인 1 : 이 공장 노동자들을 위하여 공연을 하고 싶습니다");
        }
    }
}
