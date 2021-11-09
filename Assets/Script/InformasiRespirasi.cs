using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InformasiRespirasi: MonoBehaviour
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
            output.text = "Hidung merupakan gerbang utama keluar masuknya udara setiap kali kamu bernapas. Di dalam hidung terdapat rambut-rambut halus yang berfungsi menyaring kotoran dari udara yang kamu hirup. Selain dari hidung, kamu bisa menghirup dan menghembuskan udara dari mulut.  ";
        }
        if (val == 2)
        {
            output.text = "Sinus adalah rongga udara di tulang tengkorak yang terletak di masing-masing kedua sisi hidung dekat tulang pipi, di belakang tulang hidung, diantara mata, dan ditengah dahi. Sinus berfungsi untk mengatur suhu dan kelembaban udara yang kamu hirup dari hidung. ";
        }
        if (val == 3)
        {
            output.text = "Adenoid merupakan jaringan kelenjar getah bening yang terdapat di tenggorokan. Adenoid juga membantu kamu untuk melawan infeksi dengan cara menyaring benda asing seperti kuman dan memproduksi sel limfosit untuk membunuhnya. ";
        }
        if (val == 4)
        {
            output.text = "Tonsil atau amandel adalah kelenjar getah bening yang berada di diding faring atau tenggorokan.  ";
        }
        if (val == 5)
        {
            output.text = "Faring atau tenggorokan bagian atas merupakan tabung dibelakang mulut dan rongga hidung yang menghubungkan keduanya ke trakea. ";
        }
        if (val == 6)
        {
            output.text = "Epligotis adalah sebuah katup yang terletak dibelakang lidah dan diatas laring. Epligotis berfungsi untuk mencegah makanan atau minuman selaman proses makan ketika tertutup. ";
        }
        if (val == 7)
        {
            output.text = "Laring atau kotak suara merupkan rumah bagi pita suara, terletak di bawah persimpangan faring. Laring memiliki dua pita suara yang membuka saat kamu bernapas dan menutup untuk memproduksi suara.  ";
        }
        if (val == 8)
        {
            output.text = "Trakea atau batang tenggorokan merupakan jalur yang berfungsi untuk mengalirkan udara dari dan menuju paru-paru untuk pernapasan. Trakea berada diantara laring hingga ke bawah tulang dada yang kemudian membelah menjadi dua tabung kecil yang disebut bronkus. Setiap sisi paru-paru terdapat satu bronkus.  ";
        }
        if (val == 9)
        {
            output.text = "Tulang rusuk merupakan tulang yang menopang rongga dada dan melindungi organ dalam dada seperti jantung dan paru-paru. Tulang rusuk akan mengembang dan mengempis mengikuti gerak paru-paru saat bernapas. ";
        }
        if (val == 10)
        {
            output.text = "Paru-paru adalah sepasang organ yang terletak didalam tulang rusuk. Paru-paru berperan sebagai penampung udara yang mengandung oksigen dari udara yang kamu hirup dari hidung dan akan mengalirkan oksigen tersebut ke pembuluh darah untuk disebarkan ke seluruh tubuh. ";
        }
        if (val == 11)
        {
            output.text = "Pleura adalah selaput tipis yang melapisi paru-paru, pleura berfungsi sebagai peluman yang memungkinkan paru-paru untuk mengembang dan mengempis dengan lancar setiap kali kamu bernapas. ";
        }
        if (val == 12)
        {
            output.text = "Bronkiolus atau cabang dari bronkus berfungsi untuk menyalurkan udara dari bronkus ke alveoli serta mengatur jumlah udara yang masuk dan keluar pada saat proses bernapas. ";
        }
        if (val == 13)
        {
            output.text = "Alveoli atau alveolus merupakan kantung-kantung kecil yang terdapat di ujung bronkiolus. Alveoli berfungsi sebagai tempat pertukaran oksigen dan karbon dioksida. Pada alveoli terdapat kapiler pembuluh darah yang nantinya darah akan melewati kapiler dan dibawa oleh pembuluh darah vena dan arteri. Alveoli kemudian menyerap oksigen dari udara yang dibawa oleh bronkiolus dan mengalirkannya ke dalam darah. Setelah itu, karbon dioksida dari sel-sel tubuh mengalir bersama darah ke alveoli untuk diembuskan keluar. ";
        }
        if (val == 14)
        {
            output.text = "Pada tabung bronkial terdapat silia atau rambut-rambut kecil yang akan bergerak seperti gelombang, gerakan gelombang tersebut membawa mukus atau dahak ke atas hingga ke luar tenggorokan. Fungsi dahak tersebut untuk mencegah debu, kuman, atau benda asing lain agar tidak masuk ke paru-paru. ";
        }
        if (val == 15)
        {
            output.text = "Diafragma merupakan dinding otot yang memisahkan rongga dada dari rongga perut. Diafragma akan bergerak kebawah dan menciptakan ruang kosong untuk menarik udara ketika kamu melakukan pernapasan perut.  ";
        }
    }
}
