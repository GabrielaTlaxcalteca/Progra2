using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{ 
    public class Color
    { 
        public int Rojo;
        public int Verde;
        public int Azul;

    public class Mochila
       
    {
        public int NumBolsas;
        public string Tamaño;
        public float Precio;
        public string Diseño;
        public string Material;
        public int NumLlaveros;
        public Color color;

    Mochila mochilaAna = new Mochila();
                mochilaAna.NumBolsas = 3;
                mochilaAna.Precio = 500.00f;
                mochilaAna.Diseño = "Piolin";
                mochilaAna.Material = "Vinyl";
                mochilaAna.NumLlaveros = 0;
                mochilaAna.color = new Color();
                mochilaAna.color.Rojo = 100;
                mochilaAna.color.Verde = 20;
                mochilaAna.color.Azul = 33;
 
    {
           Mochila mochilaBeto = new Mochila();
                    mochilaBeto.NumBolsas = 3;
                    mochilaBeto.Tamaño = "Grande";
                    mochilaBeto.Precio = 179.50f;
                    mochilaBeto.Diseño = "Pokemon";
                    mochilaBeto.Material = "Piel";
                    mochilaBeto.NumLlaveros = 3;
                    mochilaBeto.color = new Color();
                    mochilaBeto.color.Rojo = 0;
                    mochilaBeto.color.Verde = 128;
                    mochilaBeto.color.Azul = 210;


           
