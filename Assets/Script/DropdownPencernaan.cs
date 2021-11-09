using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropdownPencernaan : MonoBehaviour
{
    public TMP_Dropdown dropdown;

    public void PilihMulut()
    {
        dropdown.value = 1;
    }
    public void PilihEsofagus()
    {
        dropdown.value = 2;
    }
    public void PilihLambung()
    {
        dropdown.value = 3;
    }
    public void PilihUsusHalus()
    {
        dropdown.value = 4;
    }
    public void PilihUsusBesar()
    {
        dropdown.value = 5;
    }
    public void PilihRektum()
    {
        dropdown.value = 6;
    }
}
