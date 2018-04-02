﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokojZabawek
{

    public delegate void PrzekroczonaLiczbaZabawek();
    public delegate void PrzekroczonaWartoscZabawek();

    struct Wartosc
        {
            private double cena;
            private double wartoscSentymentalna;

            public double Cena
            {
                get
                {
                    return cena;
                }

                set
                {
                    if (value >= 0)
                    {
                        cena = value;
                    }
                    else
                    {
                        Console.WriteLine("Nalezy podac wartosc nieujemna!");
                    }
                }
            }

            public double WartoscSentymentalna
            {
                get
                {
                    return wartoscSentymentalna;
                }

                set
                {
                    if (value >= 0)
                    {
                        wartoscSentymentalna = value;
                    }
                    else
                    {
                        Console.WriteLine("Nalezy podac wartosc nieujemna!");
                    }
                }
            }

            public Wartosc(double cena, double wartoscSentymentalna)
            {
                this.cena = cena;
                this.wartoscSentymentalna = wartoscSentymentalna;
            }

        };

        class Zabawka
        {
            private int szybkosc;
            private int wysokosc;
            private int glebokosc;
            private int wiek;

            Wartosc wartoscBazowa;
            
            public Wartosc WartoscBazowa
            {
                get
                {
                    return this.wartoscBazowa;
                }
                set
                {
                    this.wartoscBazowa = value;
                }
            }

            public Zabawka(int szybkosc, int wysokosc, int glebokosc, int wiek, Wartosc wartoscBazowa)
            {
                this.szybkosc = szybkosc;
                this.wysokosc = wysokosc;
                this.glebokosc = glebokosc;

                this.wiek = wiek;

                this.wartoscBazowa = wartoscBazowa;

            }

            public double WartoscAktualna
            {
                get
                {
                    return (wartoscBazowa.Cena / wiek) + wartoscBazowa.WartoscSentymentalna;
                }
            }


            public int Szybkosc
            {
                get
                {
                    return this.szybkosc;
                }
                set
                {
                    if (value > 0)
                    {
                        this.szybkosc = value;
                    }
                    else
                    {
                        Console.WriteLine("Szybkosc musi byc dodatnia");
                    }
                }

            }

            public int Wysokosc
            {
                get
                {
                    return this.wysokosc;
                }
                set
                {
                    if (value > 0)
                    {
                        this.wysokosc = value;
                    }
                    else
                    {
                        Console.WriteLine("Wysokosc musi byc dodatnia");
                    }
                }

            }

            public int Glebokosc
            {
                get
                {
                    return this.glebokosc;
                }
                set
                {
                if (value > 0)
                    {
                        this.glebokosc = value;
                    }
                    else
                    {
                        Console.WriteLine("Glebokosc musi byc dodatnia");
                    }
                }

            }

            public int Wiek
            {
                get
                {
                    return wiek;
                }

                set
                {
                    if (value > 0)
                    {
                        wiek = value;
                    }
                    else
                    {
                        Console.WriteLine("Wiek musi byc dodatni");
                    }
                }
            }
        }
    
}

