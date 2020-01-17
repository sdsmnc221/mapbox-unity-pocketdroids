using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text EXP;
    [SerializeField] private Text Level;
    [SerializeField] private GameObject Menu;

    private void Awake()
    {
        Assert.IsNotNull(EXP);
        Assert.IsNotNull(Level);
        Assert.IsNotNull(Menu);
    }

    public void UpdateLevel()
    {
        Level.text = GameManager.Instance_.CurrentPlayer_.Level_.ToString();
    }

    public void UpdateEXP()
    {
        EXP.text = GameManager.Instance_.CurrentPlayer_.EXP_ + " / " + GameManager.Instance_.CurrentPlayer_.RequiredEXP_;
    }

    public void ToggleMenu()
    {
        Menu.SetActive(!Menu.activeSelf);
    }

    private void Update()
    {
        UpdateLevel();
        UpdateEXP();
    }
}
