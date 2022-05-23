using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BalanceReduction : MonoBehaviour
{
    public TextMeshProUGUI textUI;
    private int Balance=5000;
    public GameObject purchased;
    //public List<TextMeshProUGUI> TextList;
    public int[] itemPrice;
    // Start is called before the first frame update
    void Start()
    {
        //textUI.text = "Balance: $" + Balance;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (purchased.activeInHierarchy)
        {
            StartCoroutine(Delay());
        }
    }
    public void MoneyDeduction(int i)
    {
        //foreach (TextMeshProUGUI c in TextList)
        //{
        //    //var Balance = 5000;

        //    //TextMeshProUGUI value = c.GetComponentInChildren<TextMeshProUGUI>();
        //    int AmounttoDeduct =c.text;
        //    textUI.text = "Balance: " + AmounttoDeduct;
        //}
        Balance -= itemPrice[i];
        textUI.text = "Balance: " + Balance;

    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.5f);
        purchased.SetActive(false);

    }
}
