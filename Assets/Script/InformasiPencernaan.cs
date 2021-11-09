using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InformasiPencernaan: MonoBehaviour
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
            output.text = "Mulut merupakan proses awal dalam sistem pencernaan. Di dalam mulut terjadi dua proses sekaligus, dimana gigi dan lidah akan menghancurkan makanan, dan kelenjar ludah akan menghasilkan enzim dan air liur yang membantu makanan mudah untuk ditelan. Makanan tadi akan didorong ke belakang tenggorakan melalui gerakan lidah. Pada persimpangan antara tenggorakan dan kerongkongan terdapat katup yang bernama epligotis. Katup ini mencegah makanan kamu masuk ke sistem pernapasan. Makanan tadi akan terdorong kedalam faring yang kemudian akan diteruskan ke esofagus atau kerongkongan.";
        }
        if (val == 2)
        {
            output.text = "Kerongkongan atau esofagus merupakan saluran yang menghubungkan mulut kamu dengan lambung. Otot-otot kerongkongan akan memindahkan makanan tadi ke lambung, proses ini disebut gerakan peristaltik";
        }
        if (val == 3)
        {
            output.text = "Lambung memiliki tiga fungsi utama dalam sistem pencernaan, yaitu menyimpan makanan dan cairan yang tertelan, mencampur makanan dan cairan pencernaan yang diproduksi lambung, dan secara perlahan mengosongkan isinya ke dalam usus kecil. ";
        }
        if (val == 4)
        {
            output.text = "Usus halus terdiri dari 3 bagian, yaitu usus dua belas jari (duodenum), usus kosong (jejunum), dan usus penyerapan (ileum(. Dinding pada usu halus berfungsi untuk memaksimalkan pencernaan makanan dan penyerapan zat gisi. Makanan yang dicerna pada usus halus akan diserap sekitar 90 persen untuk diedarkan oleh darah ke tubuh. ";
        }
        if (val == 5)
        {
            output.text = "Usus besar terdiri dari 3 bagian, yaitu sekum (kantung pada bagian awal usus besar), kolon  (tempat cairan dan garam diserap, memanjang dari sekum ke rektum), dan rektum (bagian akhir dari usus besar). Usus besar berfungsi membuang air dan mineral elektrolit dari ampas mkanan yang tidak tercerna. ";
        }
        if (val == 6)
        {
            output.text = "Rektum merupakan tempat penampungan feses atau hasil sisa pencernaan yang akan dikeluarkan melalui anus. Tahukah kamu ketika rektum sudah mulai penuh, otot-otot disekelilingnya akan terangsang untuk mengeluarkan feses. Hal ini terjadi ketika kamu merasa mulas atau ingin buang air besar.";
        }
    }
}
