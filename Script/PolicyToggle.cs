using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PolicyToggle : MonoBehaviour
{
    public Toggle toggle;

    public float magnifyReputationLocal;    // 변경될 평판(현지)의 배율
    public float magnifyReputationHomel;    // 변경될 편판(본사)의 배율
    public float magnifyLoyal;              // 변경될 충성심의 배율
    public int magnifyMaintenanceCost;    // 변경될 유지비의 배율
    public float magnifyProfit;             // 변경될 수입의 배율
    public int useMoney;
}
