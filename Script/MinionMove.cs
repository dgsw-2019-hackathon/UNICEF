using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionMove : MonoBehaviour
{
    public GameObject minion;

    GameObject newMinion;

    private Vector3 leftPoint = new Vector3(-10, -3, 0);
    private Vector3 rightPoint = new Vector3(10, -3, 0);


    private void Start()
    {
        StartCoroutine("RightSpawn");
        //StartCoroutine("LeftSpawn");
    }

    IEnumerator RightSpawn()
    {

        newMinion = Instantiate(minion, leftPoint, Quaternion.Euler(0, 0, 0));

        StartCoroutine("Rightmove");

        yield return new WaitForSeconds(5f);

        StartCoroutine("RightSpawn");
    }

    IEnumerator Rightmove()
    {
        while (true)
        {
            newMinion.transform.position = Vector3.MoveTowards(newMinion.transform.position , rightPoint, Time.deltaTime * 5);

            yield return new WaitForFixedUpdate();

            if(newMinion.transform.position == rightPoint)
            {
                Destroy(newMinion);
                break;
            }
        }
    }

    //IEnumerator LeftSpawn()
    //{

    //    newMinion = Instantiate(minion, rightPoint, Quaternion.Euler(0, 180, 0));

    //    StartCoroutine("Leftmove");

    //    yield return new WaitForSeconds(5f);

    //    StartCoroutine("LeftSpawn");
    //}

    //IEnumerator Leftmove()
    //{
    //    while (true)
    //    {
    //        newMinion.transform.position = Vector3.MoveTowards(newMinion.transform.position, leftPoint, Time.deltaTime * 5);

    //        yield return new WaitForFixedUpdate();

    //        if (newMinion.transform.position == leftPoint)
    //        {
    //            Destroy(newMinion);
    //            break;
    //        }
    //    }
    //}

}
