using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
	public void uiSetActive()
	{
		gameObject.SetActive(!gameObject.activeInHierarchy);
	}

    public void uiSetTrue()
    {
        gameObject.SetActive(true);
    }

    public void uiSetFalse()
    {
        gameObject.SetActive(false);
    }
}
