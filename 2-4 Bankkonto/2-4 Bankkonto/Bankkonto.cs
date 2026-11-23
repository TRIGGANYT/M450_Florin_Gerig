using System;
using System.Collections.Generic;
using System.Text;

namespace _2_4_Bankkonto
{
    internal class Bankkonto
    {
        public int KontoNummer { get; }
        public int Guthaben { get; }
        public int AktivZins;
        public int PassivZins;

        public Bankkonto(int kontoNummer, int guthaben, int aktivZins, int passivZins)
        {
            KontoNummer = kontoNummer;
            Guthaben = guthaben;
            AktivZins = aktivZins;
            PassivZins = passivZins;
        }
        public void ZahleEin(int betrag) { }
        public void Beziehe(int betrag) { }
        public void Transferiere(int Kontonummer, int betrag) { }
        public void SchreibeZinsGut(int anzTage) { }
        public void SchliesseKontAb() { }

    }
}
