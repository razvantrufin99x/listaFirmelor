using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaFirmelor
{
    public class firma
    {
        //cod si denumire
        public string codfirma;
        public string denumire;
        //inregistrare
        public string numarinregistrare;
        public string cui;
        //infintare
        public string datainfintarii;
        public string dataradierii;
        //adresa
        public string codadresa;
        public string codpostal;
        public string codpozitiegeografica;
        //suprafata
        public string suprafata;
        //localizare geografica coddiviziunegraografica
        public string codsat;
        public string codcomuna;
        public string codlocalitate;
        public string codoras;
        public string codjudet;
        public string codtara;
        public string codstat;
        public string codregiune;
        public string codsubregiune;
        public string codmacroregiune;
        public string codcontinent;
        public string codzonametropolitana;
        //limba
        public string codlimba;
        //nationalitate
        public string codcetatenie;
        public string codnationalitatea;
        //banca
        public string codbancar;
        public string codbanca;
        public string codsucursala;
        //datedecontact
        ///telefonic
        public string telefon;
        public string mobil;
        public string fax;
        public string codoperatortelefonie;
        //social networks
        public string adresabaginaweb;
        public string adresaemail;
        public string adresafacebook;
        public string adresatwitter;
        public string adresawikipedia;
        public string adresayoutube;
        //personal conducere
        public string coddministrator;
        public string codsociat;
        public string codsociatjuridic;
        public string codnumeactionar;
        public string codnumepatron;
        public string codnumecontribuabil;
        //activitatea caen
        public string codactivitateaCAEN;
        public string coddomeniu;
        public string codsubdomeniu;
        public string codcategoria;
        public string codsubcateoria;
        public string descriereactivitate;
        //forma juridica
        public string codformajuridica;
        public string notepersonale;
        //descrierea firmei
        public string descrierea;
        //activitatea
        public bool seaflaininsolventa;
        public bool seaflainlichidare;
        public bool seaflaindesfintare;
        public bool functioneaza;
        public string starefunctionare;
        //finantarea
        public string schemadefinantare;
        public string codtipcomert;
        public string categoriidemarime;
        //autorizare
        public string dateautorizare;
        //prezentare
        public string codlogo;
        //sediu
        public string expirasediulsocial;
        public string nrsediisecundare;
        //monitorizare
        public string codbpinsoventa;
        public string codpijudecata;
        public string codmonitoruloficial;
        public string submonitorizare;
        public string faliment;
        //istoric
        public string istoric;
        //angajati
        public string numardeangajati;
        //capitaluri
        public string capitalsocial;
        public string profit;
        public string active;
        public string datorii;
        public string cheltuieli;
        public string capitalpropriu;
        public string venituri;
        public string datoriianaf;
        public string datoriisalariale;
        public string salariilunare;
        public string salariianuale;
        public string salariitotaleanuale;
        public string salariitotalelunare;
        //tva
        public string codregimtva;
        public string codregimtvaincasare;
        public string codregimsplittva;
        //furnizori
        public List<string> listacodurifurnizori;
        //clientipf
        public List<string> listacoduriclienti;
        //produse
        public List<string> listacoduriproduse;
        //servicii
        public List<string> listacoduriservicii;



    }
}
