using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naloga1
{

    //TODO ustvarite razred Indexers
    class Indexers
    {


        //TODO dodajte field Dictionary osebe, ki vsebuje naziv (string) in starost (int)
        //Dictionary<TKey,TValue> Class = new ....
        //koda 

        //TODO ustvarite propery steviloDodajanj (get, private set) s privzetno vrednostjo 0
        //koda


        //TODO ustvarite metodo dodajOsebo (vhodni parameter je naziv (string) in starost (int))
        //TODO poveča števec steviloDodajanj
        //TODO če je starost >= 18 doda osebo vendar preveri, če morda že obstaja
        //TODO v kolikor obstaja, popravi starost osebe

        
        public void dodajOsebo(string naziv, int starost)
        {
            //koda
            //pomoc ContainsKey
            
        }


        //TODO ustvarite metodo, ki vrne prvo osebo slovarja in njeno starost v obliki "naziv - starost"
        //TODO v kolikor v slovarju ni zapisov vrnite "" prazen string
        //TODO pomoč: var prvaOseba = osebe.First();
        public string vrniPrvoOsebo()
        {
            //koda
            //pomoc .Count   .First(), .Key. Value
            return "";
        }

    }

}
