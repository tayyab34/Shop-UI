using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BalanceReduction : MonoBehaviour
{
    public TextMeshProUGUI textUI;
    private int Balance = 5000;
    private int AmounttoDeduct =100;
    public GameObject purchased;
    // Start is called before the first frame update
    void Start()
    {
        textUI.text = "Balance: $" + Balance;
    }

    // Update is called once per frame
    void Update()
    {
        if (purchased.activeInHierarchy)
        {
            StartCoroutine(Delay());
        }
    }
    public void MoneyDeduction()
    {
        Balance -= AmounttoDeduct;
        textUI.text = "Balance: $" + Balance;

    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.5f);
        purchased.SetActive(false);

    }
}
