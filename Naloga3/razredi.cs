using System;
using System.Collections.Generic;
using System.Text;

namespace Naloga3
{
    //TODO: ustvarite vrstaZivaliSeznam tipa enum
    //TODO: dodajte zapise Domacazival, Divjazival, Zver
    //koda

    //TODO ustvarite interface Izival
    interface IZival
    {
        //!!!!! interface cannot contain instance fields
        //!!!!! public string vrednost = "";

        // Property declaration:
        //TODO ustvarite lastnosti string VrstaZivali (get), int SteviloNog (get,set), string NazivZivali(get,set)
        //koda 3x


        //TODO ustvarite metode Oglasanje (vrne string), brez vhodnih parametrov
        //koda

        //TODO ustvarite metodo HitrostGibanja (vrne int), brez vhodnih parametrov
        //koda

    }
    //TODO ustvarite abstraktni razred Zival, ki implementira interface IZival
    //koda definicja razreda (popraviti class AAAA)
    class AAAA
    {
        //TODO: ustvarite field _stevilonog tipa int s privzetno vrednostjo 0. ki bo dosegljiv le v tem razredu
        //koda

        //TODO: ustvarite field _nazivZivali tipa string, ki bo dosegljiv tudi v dedovanih razredih
        //koda


        //TODO implementirajte property SteviloNog (vrne in določi field _stevilonog tipa int)
        public int SteviloNog
        {
            get
            {
               // return _stevilonog;
            }
            set
            {
               // _stevilonog = value;
            }
        }


        //TODO implementirajte property NazivZivali (vrne in določi field _nazivZivali tipa int)
        //koda kot zgoraj samo z lambda expresnom (krajše)



        //TODO dodajte abstraktni property VrstaZivali tipa string (samo get)
        //koda

        //TODO dodajte abstraktno metodo Oglasanje tipa string, brez vhodnih parametrov 
        //koda


        //TODO dodajte abstraktno metodo Gibanje tipa string, brez vhodnih parametrov
        //koda


        //TODO dodajte virtualno metodo HitrostGibanja tipa int, brez vhodnih parametrov, ki vrne vrednost 0
        //koda
    }


    //TODO ustvarite razred Petelin, ki je dedovana iz razreda Zival
    //koda
    public class BBBBB
    {
        //TODO ustvarite field _vrstaZivali tipa int in mu dodelite vrednost (int)vrstaZivaliSeznam.Domacazival
        //koda (potrebno parsati v int)
        


        //TODO ustvarite konstruktor Petelin(string pNaziv, int pSteviloNog), 
        // vrednosti zapišite v ustrezne Propery Stevilo Nog in NazivZivai
        public Petelin(string pNaziv, int pSteviloNog)
        {
            //koda 2 vrstici
        }

        //TODO ustvarite VrstaZivali, ki vrne (get) _vrstaZivali vrne string iz enum vrstaZivaliSeznam (primer: Divjazival)
        //koda

        //TODO ustvarite metodo Oglasanje, ki vrne string "Kikiriki"
        //koda

        //TODO ustvarite metodo Gibanje, ki vrne string "Leti"
        //koda
    }


    //TODO ustvarite razred Tiger, ki je dedovana iz razreda Zival
    public class Tiger : Zival
    {
        //TODO ustvarite field _vrstaZivali tipa int in mu dodelite vrednost (int)vrstaZivaliSeznam.Zver
        //koda

        //TODO utvarite field _steviloZob tipa int in mu dodelite privzetno vrednost 0
        //dosegljivost naj bo le znotraj razreda
        //

        //TODO ustvarite konstruktor Tiger(string pNaziv, int pSteviloNog, nt pSteviloZob), vrednosti zapišite v ustrezne Propery
        //koda konsturktor

        //TODO ustvarite VrstaZivali, ki vrne (get) _vrstaZivali vrne string (primer: Zver)
        //koda

        //TODO ustvarite metodo Oglasanje, ki vrne string "KikRjovenjeiriki"
        // koda
        //TODO ustvarite metodo Oglasanje, ki vrne string "Teče"
        //koda

    }
    //TODO:ustvarite razred Razsiritve
    static class razsitive
    {

        //TODO: ustvarite razsiritev Opis za Tiger
        //TODO: izpiše naj podatke o Tigru stevilonov, gibanje, oglasanje
        //koda   public static int WordCount(this String str) {}

    }


}

