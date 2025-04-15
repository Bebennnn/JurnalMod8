using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Modul8_103022330122;

class program
{
    static void Main(String[] args)
    {
        BankTransferConfig config = new BankTransferConfig();
        int Masukkan;

        if (config.lang == "en")
        {
            Console.WriteLine("Please insert the amount of money to transfer:");
        }
        else
        {
            Console.WriteLine("“Masukkan jumlah uang yang akan di-transfer:");
        }

        Masukkan(Console.ReadLine());

        if (config.tranfer >= 25000000)
        {
            Console.WriteLine(Masukkan - config.trasnfer.low_fee);
        } else {
            Console.WriteLine(Masukkan - config.transfer.high_fee);
    }
}
