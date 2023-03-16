using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_proveChiareComposition
{




    class Continente
    {        
        
        string _nomecontinente;
        Paese _paese;

        public Continente(string nomeContinente) 
        {
            _nomecontinente = nomeContinente;
        }

        //changeComune
        public void changeComune(string nomePaeseDest, string nomeRegioneDest, string nomeProvinciaDest, string nomeComuneDest) 
        {
            Paese paese = new Paese(nomePaeseDest);
            paese.changeComune(nomeRegioneDest, nomeProvinciaDest, nomeComuneDest);
        }

            internal class Paese
            {
                string _nomePaese;

                Regione _regione;

                public Paese(string nome)
                {
                    this._nomePaese = nome;
                }

                //changeComune
                public void changeComune( string nomeRegione, string nomeProvincia , string nomeComune)
                {
                   
                   Regione regione = new Regione(nomeRegione);
                    regione.changeComune(nomeProvincia , nomeComune);
                }

                public void createRegione(string nomeRegione)
                {
                    _regione = new Regione(nomeRegione);

                }

                    class Regione
                    {
                        string _name;
                        Provincia _provincia;

                        public Regione(string name)
                        {

                            this._name = name;

                        }

                        //changeComune
                        public void changeComune( string nomeProvincia, string nomeComune)
                        {
                            Provincia provincia = new Provincia(nomeProvincia);
                            provincia.changeComune(nomeComune);
                        }

                                    class Provincia 
                                    {
                                        string _name;
                                        Comune _nomeComune;

                                          public Provincia(string nomeProvincia) {
                                            _name = nomeProvincia;
                                            }

                                        public void changeComune( string nomeComune)
                                        {
                                         _nomeComune = new Comune(nomeComune);
                                        }



                                                       class Comune 
                                                       {
                                                         string _name;

                                                        public Comune(string nomeComune) {
                        
                                                            _name = nomeComune;

                                                        }


                                                     

                    }       
                
                                    }   
                    }
          

        }
    }
}
