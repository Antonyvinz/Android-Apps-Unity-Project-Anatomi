using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropdownRespirasi: MonoBehaviour
{
    public TMP_Dropdown dropdown;

    public void PilihHidung()
    {
        dropdown.value = 1;
    }
    public void PilihSinus()
    {
        dropdown.value = 2;
    }
    public void PilihAdenoid()
    {
        dropdown.value = 3;
    }
    public void PilihTonsil()
    {
        dropdown.value = 4;
    }
    public void PilihFaring()
    {
        dropdown.value = 5;
    }
    public void PilihEpiglotis()
    {
        dropdown.value = 6;
    }
    public void PilihLaring()
    {
        dropdown.value = 7;
    }
    public void PilihTrakea()
    {
        dropdown.value = 8;
    }
    public void PilihRusuk()
    {
        dropdown.value = 9;
    }
    public void PilihParuParu()
    {
        dropdown.value = 10;
    }
    public void PilihPleura()
    {
        dropdown.value = 11;
    }
    public void PilihBronkiolus()
    {
        dropdown.value = 12;
    }
    public void PilihAlveoli()
    {
        dropdown.value = 13;
    }
    public void PilihBronkial()
    {
        dropdown.value = 14;
    }
    public void PilihDiafragma()
    {
        dropdown.value = 15;
    }
}
