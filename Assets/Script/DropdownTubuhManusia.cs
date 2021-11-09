using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropdownTubuhManusia : MonoBehaviour
{
    public TMP_Dropdown dropdown;

    public void PilihKepala()
    {
        dropdown.value = 1;
    }
    public void PilihTangan()
    {
        dropdown.value = 2;
    }
    public void PilihBadanAtas()
    {
        dropdown.value = 3;
    }
    public void PilihBadanBawah()
    {
        dropdown.value = 4;
    }
    public void PilihKaki()
    {
        dropdown.value = 5;
    }
}
