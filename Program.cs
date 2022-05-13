/*
 * Creare la classe Prodotto che gestisce i prodotti dello shop. Un prodotto è caratterizzato da:
 *  - codice (numero intero) - nome - descrizione - prezzo - iva 
 * Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che: 
 *  -Alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random.
 *  -Il codice prodotto sia accessibile solo in lettura Gli altri attributi siano accessibili sia in lettura che in scrittura.
 *  -Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva.
 *  -Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome 
 *  -Nella vostro programma principale, testate tutte le funzionalità della classe Prodotto. 
 * 
 * BONUS: create un metodo che restituisca il codice con un pad 
 * left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace csharp_oop_shop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Prodotto p1 = new Prodotto("Pallone", "Pallone da basket", 33,22);
            
           // double price=p1.getPrice(123.2);
           // double priceWithIva=p1.getPriceWithIva();
           // string fullName= p1.getFullName();
           // string description = p1.getDescription();
            Console.WriteLine("Nome: {0}", p1.getName());
            Console.WriteLine("Prezzo: {0}", p1.getPrice());
            Console.WriteLine("Descrizione: {0}", p1.getDescription());
            Console.WriteLine("Prezzo con iva: {0}", p1.getPriceWithIva());
            Console.WriteLine("Nome completo: {0}", p1.getFullName());


        }

        
    }
}