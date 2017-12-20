using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Modelo;

namespace Controlador
{
    ///////////////////////////////////////////////////////////
    //  Original author: sebastian
    ///////////////////////////////////////////////////////////
    public class CargarCancionControlador
    {
        private string pathCancion;
        public Cancion canc;
        public string instrument;

        public CargarCancionControlador(string path, string inst)
        {
            instrument = inst;
            pathCancion = path;
            canc = new Cancion();
            buscarEnXML();
            fullIntrumentPositions();
        }

        public void buscarEnXML()
        {
            try
            {
                //string tempoCan;
                XDocument miXML = XDocument.Load(pathCancion); //Cargar el documento 
                var tempo = from tabTempo in miXML.Descendants("sound")
                            select new
                            {
                                temp = tabTempo.Attribute("tempo").Value
                            };
                foreach (var pu in tempo)
                {
                    canc._tempo = Convert.ToInt32(pu.temp);
                }

                

                var data = from item in miXML.Descendants("note")
                           select new
                           {
                               alter = item.Element("pitch").Element("alter"),
                               nota = item.Element("pitch").Element("step").Value,
                               octava = item.Element("pitch").Element("octave").Value,
                               duracion = item.Element("duration").Value,
                               tipo = item.Element("type").Value
                           };
                foreach (var p in data)
                {
                    string noteName = "";

                    // if there is alter it asigns, if is null, put ""
                    string isAlter = (string)p.alter ?? "";

                    if (isAlter.Equals("1"))
                        noteName = p.nota + "#";
                    else
                        noteName = p.nota;

                    Nota notaTemp = new Nota(noteName, p.octava, p.tipo);
                    canc.agregarNota(notaTemp);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                //aquí código regreso a formulario lecciones
            }
        }
    


        public void fullIntrumentPositions()
        {
            // so that this works the file must be in debug, not very good i think
            //XDocument miXml = XDocument.Load(@"notesPositions.txt");
            string instrumentXml = "";

            switch (instrument)
            {
                case "diatonicHarmonicaE":
                    instrumentXml = "notesPositionsDiatonicHarmonicaE";
                    break;
                default: //guitar
                    instrumentXml = "notesPositionsGuitar";
                    break;
            }

                XDocument miXml = XDocument.Load(@"Content/metaData/" + instrumentXml + ".xml");

            for (int i = 0; i < canc.notas.Count; i++)
            {
                Console.WriteLine(canc.notas[i]._nombre + canc.notas[i]._octava);
                var data = from item in miXml.Descendants("note")//, item2 in miXml.Descendants("nota").Descendants("posiciones")
                           where item.Element("name").Value == canc.notas[i]._nombre + canc.notas[i]._octava
                           select new 
                           {
                               posX = item.Element("positions").Elements("pos").Elements("posx"),//.Value,
                               posY = item.Element("positions").Elements("pos").Elements("posy"),
                               posPart = item.Element("positions").Element("posSheet").Value
                           };
                //int temp;
                
                foreach (var p in data)
                {
                    canc.notas[i].posicionPart = Convert.ToInt32(p.posPart);

                   /* 
                    * esta belleza es lo que trate de hacer para recoger todas las pocisiones, por que no pense 
                    * en usar el foreach con xelement desde el principio, nunca lo sabre
                    * 
                    * temp = Convert.ToInt32(p.posX.ElementAt(0).Value);
                    p.posX.Count(
                    while (temp != null)
                    {
                        canc.notas[i].posicionMastilX.Add(Convert.ToInt32(temp));
                        i++;
                    }*/
                    foreach(XElement temp in p.posX)
                    {
                        canc.notas[i].posicionMastilX.Add(Convert.ToInt32(temp.Value));
                    } 
                    
                    foreach (XElement temp in p.posY)
                    {
                        canc.notas[i].posicionMastilY.Add(Convert.ToInt32(temp.Value));
                    }

                }

                switch (canc.notas[i]._duracion)
                {
                    case "whole":
                        canc.notas[i].margenSigNota = 400;
                        canc.notas[i].indiceImagen = 0;
                        break;
                    case "half":
                        canc.notas[i].margenSigNota = 200;
                        canc.notas[i].indiceImagen = 1;
                        break;
                    case "quarter":
                        canc.notas[i].margenSigNota = 100;
                        canc.notas[i].indiceImagen = 2;
                        break;
                    case "eighth":
                        canc.notas[i].margenSigNota =50;
                        canc.notas[i].indiceImagen = 3;
                        break;
                    case "16th":
                        canc.notas[i].margenSigNota = 25;
                        canc.notas[i].indiceImagen = 4;
                        break;
                }
          
            }
        }
    }
}
