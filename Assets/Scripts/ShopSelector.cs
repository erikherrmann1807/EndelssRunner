using UnityEngine;

public class ShopSelector : MonoBehaviour {
    public GameObject mainMenuPanel;
    public GameObject shopPanel;

    public void ShowShopPanel() {
        shopPanel.SetActive(true);
        mainMenuPanel.SetActive(false);
    }

    private void Start() {
        ShowMenuPanel();
    }

    public void ShowMenuPanel() {
        mainMenuPanel.SetActive(true);
        shopPanel.SetActive(false);
    }
}