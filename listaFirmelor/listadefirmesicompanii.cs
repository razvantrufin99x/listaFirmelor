using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listaFirmelor
{
    public  class listadefirmesicompanii
    {
        public string codlfc;

        //sunt doar codurile inscrise aici ca un index 
        //pentru fiecare va exista operatiuni de salvare a datelor in tabele si baze de date sau fisiere
        //operatiuni de citire, update si marcare pentru stergere
        //operatiuni de copiere, cautare, listare, selectare, filtrare, 
        //operatiuni de conversie si ordonare 
        //operatiuni de alertare sin control
        //operatiuni de curatire a datelor 
        //operatiuni de administrare
        //operatiuni de reverificare
        //operatiuni de backup, mutare 
        //operatiuni de tip comercial cu date
        //pentru fiecare lista exista cate un obiect sau mai multe care se crea si cu care se vor realiza toate operatiunile
        //pentru aceasta trebuie sa cream aceste obiecte din clase diferite 
        //pentru cele care nu exista clase deja create trebuie sa se realizeze noi clase 
        //trebuie sa se realizeze si o interfata grafica
        //si mai este necesara crearea unui site web sau o interfata cu un server
        //si un server si un client
        //pentru crearea bazei de date este necesara stabilirea formatului si dimensiunea datelor
        //validari si verificari asupra datelor introduse

        //logare , signin
        //autorizare
        //sesiune
        //cookies
        //statistica
        //agregare
        //contabile
        //chart
        //histograma
        //raport
        //printare

        public listadefirmesicompanii()
        {
            this.addBancile();
            this.addCetateniile();
            this.addContinentele();
            this.addDomeniile();
            this.addFormeJuridice();
            this.addJudetele();
            this.addLimbile();
            this.addNationalitatile();
            this.addOrasele();
            this.addTarile();
        }
        public List<string> listcodurideformulare = new List<string>();
        
        public List<string> listcodurilorforms = new List<string>();

        public List<string> listcoduridebazededate = new List<string>();
        public List<string> listcoduridetabele = new List<string>();
        
        public List<string> listcoduridesqlcodes = new List<string>();

        //administratori si administrare

        public List<string> listcodurideadministratori = new List<string>();
        public List<string> listcodurideoperatori = new List<string>();
        public List<string> listcodurideangajati = new List<string>();
        public List<string> listcodurideprogramatori = new List<string>();
        public List<string> listcoduridecolaboratori = new List<string>();
        public List<string> listcoduridecolaboratoriexterni= new List<string>();
        public List<string> listcoduridefirmecolaboratoare = new List<string>();

        //operare si operatori
        //privilegii si limitari
        //angajati si programatori dezvoltatori
        //conditii legale de copyright si drepturi asupra datelor si codului
        //verificari legale privind autenticitatea datelor
        //colaborari cu justitia si mai si securitatea interna si internationala

        //sql code si sql tranzactii stocate, view, cursor...

        //distributie pe medii de stocare 

        //cursuri de perfectionare pentru angajati si administratori

        //vanzarea de servicii 
        //import si export de date
        //crowling pe internet



        //servicii de seo pentru searchengines

        //vanzare de spatiu publicitar


        //unele dintre aceste liste vor fi doar niste liste indexul urmand sa fie codul utilizat
        //lista continente, tari, orase, judete, regiuni, subregiuni ...doar o lista dar poate avea sau nu un obiect in spate
        //lista bancile, domenii, subdomenii, categorii, subcategorii
        //lista regim tva,... 
        //lista tip de comert
        //lista forme juridice, caen
        //lista operatori telefonic 
        //liste geografice
        //liste nationalitatim cetatenii, limbi, scris 
        //lista eliberatdecatre
        //lisa culorilor piele, ochi, par
        //lista sucursale, filiale, sedii
        

        //lf
        public List<string> listcoduridefirme  = new List<string>();

        public List<string> listcoduridepersoane = new List<string>();
        
        public List<string> listcoduridebanci = new List<string>();
        public void addBancile()
        {
            listcoduridebanci.Add("BCR");


        }

        public List<string> listcoduridediviziunigeografie = new List<string>();
        
        public List<string> listcoduridedomenii = new List<string>();
        public void addDomeniile()
        {
            listcoduridedomenii.Add("Bancar");


        }
        public List<string> listcoduridesubdomenii = new List<string>();
        public List<string> listcoduridecategorii = new List<string>();
        public List<string> listcoduridesubcategorii = new List<string>();
        
        public List<string> listcoduridelogouri = new List<string>();
        
        public List<string> listcoduridesedii = new List<string>();
        
        public List<string> listcoduridestrazi = new List<string>();
        
        public List<string> listcodurideregimtva = new List<string>();
        public List<string> listcodurideregimtvaincasare = new List<string>();
        public List<string> listcodurideregimsplittva = new List<string>();
        
        public List<string> listcoduridetipdeomert = new List<string>();
        public List<string> listcodurideformefuridice = new List<string>();
        public void addFormeJuridice()
        {
            listcodurideformefuridice.Add("PF");
            listcodurideformefuridice.Add("PFA");
            listcodurideformefuridice.Add("PJ");


        }
        public List<string> listcodurideactivitatiCAEN = new List<string>();
        
        public List<string> listcodurideoperatoritelefonie = new List<string>();

        public List<string> listcoduridenationalitati = new List<string>();
        public void addNationalitatile() {
            listcoduridenationalitati.Add("Romana");


        }
        public List<string> listcoduridecetatenii = new List<string>();
        public void addCetateniile()
        {
            listcoduridecetatenii.Add("roman");


        }
        public List<string> listcoduridelimbi = new List<string>();
        public void addLimbile()
        {
            listcoduridelimbi.Add("Romana");


        }


        public List<string> listcoduridecontinente = new List<string>();
        public void addContinentele()
        {
            listcoduridecontinente.Add("Europa");


        }
        public List<string> listcoduridemacroregiuni = new List<string>();
        public List<string> listcoduridesubregiuni = new List<string>();
        public List<string> listcodurideregiuni = new List<string>();
        public List<string> listcoduridestate = new List<string>();

        public List<string> listcoduridetari = new List<string>();
        public void addTarile()
        {
            listcoduridetari.Add("Romania");


        }
        public List<string> listcoduridejudete = new List<string>();
        public void addJudetele()
        {
            listcoduridejudete.Add("Bucuresti");
            listcoduridejudete.Add("Sibiu");


        }
        public List<string> listcodurideorase = new List<string>();
        public void addOrasele()
        {
            listcodurideorase.Add("Bucuresti");
            listcodurideorase.Add("Sibiu");

        }
        public List<string> listcoduridelocalitati = new List<string>();
        public List<string> listcoduridecomune = new List<string>();
        public List<string> listcoduridesate = new List<string>();
        public List<string> listcoduridezonemetropolitane = new List<string>();
        public List<string> listcodurideadrese = new List<string>();
        public List<string> listcoduripostale = new List<string>();
        public List<string> listcoduridepozitiigeografice = new List<string>();

        public List<string> listcodurideeliberarecibi = new List<string>();

        public List<string> listcodurideculorialepielii = new List<string>();
        public List<string> listcodurideculorialeochilor = new List<string>();
        public List<string> listcodurideculorialeparului = new List<string>();

        public List<string> listcoduridesucursale = new List<string>();

        public List<string> listcodurideforme = new List<string>();


        //formulare
      

        public List<formular> listaFormularelor = new List<formular>();
        public void createFormular(
            string pcodformular,
            Form pformName           
            ) {
            listaFormularelor.Add(new formular());
            listaFormularelor[listaFormularelor.Count-1].codformular = pcodformular;
            listaFormularelor[listaFormularelor.Count - 1].formName = pformName;
        }



    }
}
