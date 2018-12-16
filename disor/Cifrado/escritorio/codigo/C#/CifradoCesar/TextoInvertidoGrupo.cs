using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CifradoCesar
{
    class TextoInvertidoGrupo
    {
        public String invertirCadena(String texto,int grupo)
        {
			/*char[] textoinvertido={}; int indice=0;
           // char[] charArray = texto.ToCharArray();
            while(indice< texto.Length){
             textoinvertido=  texto.Substring(indice,grupo+indice).ToCharArray();
             indice += grupo;
            }
           
            Array.Reverse(textoinvertido);
             return new string(textoinvertido);*/
			InvertirCadena invertirCad = new InvertirCadena();
			int indice = 0;
			string text = "";
			while (indice < texto.Length)
			{
				if (indice== indice+(grupo-1))
				{
					text =invertirCad.invertirCadena(texto.Substring(indice-grupo, indice + (grupo - 1)));
				}
			}
			return text;
        }
    }
}
