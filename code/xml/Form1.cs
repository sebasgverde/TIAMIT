using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace xmlControlador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                 crear_XML();
        }

        private void crear_XML() 
{ 
            XDocument miXML = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), 
                new XElement("Empleados", 
 
                new XElement("Empleado", 
                new XAttribute("Id_Empleado", "321654"), 
                new XElement("Nombre", "Miguel Suarez"), 
                new XElement("Edad", "30")), 
 
                new XElement("Empleado", 
                new XAttribute("Id_Empleado", "123456"), 
                new XElement("Nombre", "Maria Martinez"), 
                new XElement("Edad", "27")), 
 
                new XElement("Empleado", 
                new XAttribute("Id_Empleado", "987654"), 
                new XElement("Nombre", "Juan Gonzales"), 
                new XElement("Edad", "25")) 
                )); 
            miXML.Save(@"C:\Users\sebastian\Desktop\MiDoc.xml"); //Debes tener permisos sobre la carpeta 
            MessageBox.Show("Se ha creado un XML"); 
}

        private void button2_Click(object sender, EventArgs e)
        {
            buscarEnXML();
        }

        private void buscarEnXML()
        {
            //string tempoCan;
            XDocument miXML = XDocument.Load(@"C:\Users\sebastian\Desktop\notas.xml"); //Cargar el documento 
            var tempo = from tabTempo in miXML.Descendants("sound")
                        select new 
                        { 
                            temp = tabTempo.Attribute("tempo").Value
                        };
            foreach (var pu in tempo)
            {
                //tempoCan = pu.temp;
                
                MessageBox.Show(pu.temp);
            }
            
            var data = from item in miXML.Descendants("note")
                       select new
                       {
                           nota = item.Element("pitch").Element("step").Value,
                           octava = item.Element("pitch").Element("octave").Value,
                           duracion = item.Element("duration").Value,
                           tipo = item.Element("type").Value
                       };
            foreach (var p in data)
            {
                MessageBox.Show(p.nota + " " + p.octava + " " + p.duracion + " " + p.tipo);
               // Console.Beep(,string. tempoCan.)
            }
            /*XDocument miXML = XDocument.Load(@"C:\Users\sebastian\Desktop\MiDoc.xml"); //Cargar el documento 
            var data = from item in miXML.Descendants("Empleado")
                       select new
                       {
                           nombre = item.Element("Nombre").Value,
                           edad = item.Element("Edad").Value,
                       };
            foreach (var p in data)
                MessageBox.Show(p.nombre + " " + p.edad);*/
           /* var nombreusu = from empleado in miXML.Elements("Empleados")
                            //where nombre.Attribute("Id_Empleado").Value == idempleado //Consultamos por el atributo 
                            //select nombre.Element("Nombre").Value,sum(edad.Element("Edad").value); //Seleccionamos el nombre 
                            select empleado.Element("Empleado").Value;

            var nom= from nombre in miXML.Elements("Empleados").Elements("Empleado")
                           /// where nombre.Attribute("Id_Empleado").Value == idempleado //Consultamos por el atributo 
                            select nombre.Element("Nombre").Value; //Seleccionamos el nombre 
                            
            //  var notas = from 

            foreach (string minom in nombreusu)
            {
                MessageBox.Show(minom); //Mostramos un mensaje con el nombre del empleado que corresponde 
            }
           foreach (string yo in nom)
            {
                MessageBox.Show(yo);//Mostramos un mensaje con el nombre del empleado que corresponde 
            }*/
        }
    }
}
