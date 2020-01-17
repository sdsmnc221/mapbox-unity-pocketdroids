using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXPBonus : MonoBehaviour
{
    [SerializeField] private int Bonus = 10;

    private void OnMouseDown()
    {
        GameManager.Instance_.CurrentPlayer_.AddEXP(Bonus);
        Destroy(gameObject);
    }
}
