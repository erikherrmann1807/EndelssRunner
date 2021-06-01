using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour {

    public int bankBalance;
    public Text bankBalanceText;
    
    // Start is called before the first frame update
    private void Start() {
        RefreshBankBalance();
    }

    public void BuyItem(int itemPrice) {
        //check bank balance
        if (bankBalance >= itemPrice) {
            Debug.Log("Item wurde gekauft!");
            //Add PowerUp
            //calculate new bank balance
            bankBalance -= itemPrice;
            //refresh bank balance(text)
            RefreshBankBalance();
        }
    }

    void RefreshBankBalance() {
        bankBalanceText.text = bankBalance.ToString();
    }
}