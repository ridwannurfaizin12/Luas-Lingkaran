using System;

namespace Luas_Lingkaran
{
    /// <summary>
    /// luaslingkaran sebagai main class
    /// </summary>
    /// <remarks>
    ///  pada luasLingkaran terdapat variabel dan juga memiliki beberapa method
    ///  method input untuk pengguna memasukkan nilai jejari
    ///  method hitung untuk menghitung luaslingkaran dengan rumus
    ///  method main membantu metode utama untuk dimuat tanpa terpengaruh oleh instance/objek apa pun
    /// </remarks>
    class luasLingkaran
    {
        /// <summary>
        /// operasi input data
        /// </summary>
        /// <remarks>
        /// menentukan nilai jejari untuk menghitung luas lingkaran
        /// </remarks>
        /// <code>
        /// lingkaran.input();
        /// </code>
        double jejari, phi = 3.14;
        public void input()
        {
            Console.Write("Masukkan r: ");
            jejari = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// hitung sebagai method atau fungsi
        /// </summary>
        /// <param name="r">jari-jari lingkaran</param>
        /// <returns>hasil dari luas lingkaran</returns>
        public double hitung(double r)
        {
            return phi * r * r;
        }

        /// <summary>
        /// tampilHasil sebagai method atau fungsi
        /// </summary>
        /// <remarks>
        /// menampilkan hasil dari menginput nilai jejari kemudian dihitung menggunakan method hitung
        /// </remarks>
        /// <code>
        /// lingkaran.tampilHasil();
        /// </code>
        public void tampilHasil()
        {
            Console.WriteLine("Luas Lingkaran = " + this.hitung(jejari) + " cm" ) ;
        }

        /// <summary>
        /// main sebagai method atau fungsi
        /// </summary>
        /// <param name="args">mendefinisikan variable array string </param>
        static void Main(string[] args)
        {
            luasLingkaran lingkaran = new luasLingkaran();
            lingkaran.input();
            lingkaran.tampilHasil();
            Console.ReadKey();
        }
    }
}
