using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InformasiTubuhManusia : MonoBehaviour
{
    public TextMeshProUGUI output;

    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            output.text = " ";
        }
        if (val == 1)
        {
            output.text = "Bagian kepala terdiri dari rambut, dahi, alis, mata, bulu mata, telinga, hidung, mulut, dagu. Dalam mulut terdapat gusi, gigi, lidah, dan bibir.";
        }
        if (val == 2)
        {
            output.text = "Bagian tangan terdiri dari ketiak, lengan atas, sikum lengan bawah, telapak tangan, dan jari. Jari terdapat 5 jenis; ibu jari, jari telunjuk, jari tengah, jari manis, dan kelingking.";
        }
        if (val == 3)
        {
            output.text = "Pada bagian badan atas terdapat leher, bahu, dada, perut, punggung. ";
        }
        if (val == 4)
        {
            output.text = "Bagian badan bawah terdapat pinggang, panggul, pantat, kemaluan, dubur dan buah pelir untuk laki-laki.";
        }
        if (val == 5)
        {
            output.text = "Anggota tubuh yang tedapat di bagian kaki adalah paha, lutut, betis, mata kaki, telapak kaki, tumit dan jari kaki. ";
        }
    }
}
