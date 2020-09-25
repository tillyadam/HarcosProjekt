﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarcosProjekt
{
    class Harcos
    {
        private string nev;
        private int szint;
        private int tapasztalat;
        private int eletero;
        private int alapEletero;
        private int alapSebzes;

        public Harcos(string nev, int statuszSablon)
        {
            this.nev = nev;
            this.szint = 1;
            this.tapasztalat = 0;

            if (statuszSablon == 1)
            {
                alapEletero = 15;
                alapSebzes = 3;
            }
            else if (statuszSablon == 2)
            {
                alapEletero = 12;
                alapSebzes = 4;
            }
            else if (statuszSablon == 3)
            {
                alapEletero = 8;
                alapSebzes = 5;
            }
            this.eletero = alapEletero;

        }


        public string Nev { get => nev; set => nev = value; }
        public int Szint { get => szint; set => szint = value; }
        public int Tapasztalat { get => tapasztalat; set => tapasztalat = value; }
        public int Eletero { get => eletero; set => eletero = value; }
        public int AlapEletero { get => alapEletero; }
        public int AlapSebzes { get => alapSebzes; }
        public int Sebzes { get => alapSebzes + szint; }
        public int SzintLepeshez { get => 10 + szint * 5; }
        public int MaxEletero { get => alapEletero + szint * 3; }

        public void Megkuzd(Harcos masikHarcos)
        {
            bool error = false;
            if (this.nev == masikHarcos.nev)
            {
                Console.WriteLine("Ugyan az a harcos");
                error = true;
            }
            if (this.eletero == 0 || masikHarcos.eletero == 0)
            {
                Console.WriteLine("0 eletero");
                error = true;
            }

            
            do
            {
                if (masikHarcos.eletero > 0)
                {
                    this.eletero -= masikHarcos.Sebzes;
                    if (this.eletero>0)
                    {
                        this.tapasztalat += 5;
                    }
                    else
                    {
                        masikHarcos.tapasztalat += 10;
                    }
                }
                if (this.eletero > 0)
                {
                    masikHarcos.eletero -= this.Sebzes;
                    if (masikHarcos.eletero > 0)
                    {
                        masikHarcos.tapasztalat += 5;
                    }
                    else
                    {
                        this.tapasztalat += 10;
                    }
                }
                
            } while (masikHarcos.eletero>0 && this.eletero>0);            


        }
        public void Gyogyul()
        {

        }

        public override string ToString()
        {
            return string.Format("{0} - LVL: {1} - EXP: {2} - HP: {3} - DMG: {4}", nev, szint, tapasztalat / SzintLepeshez, eletero / MaxEletero, Sebzes); ;
        }

    }
}
