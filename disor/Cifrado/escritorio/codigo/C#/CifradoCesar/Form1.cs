using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CifradoCesar
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		Cifrador cifrar = new Cifrador(); InvertirCadena inverso = new InvertirCadena();
		Abecedario abc = new Abecedario();
		private void SoltoTeclaTextoPlano(object sender, KeyEventArgs e){
            Cifrador cifrar = new Cifrador();
           
        }

        private void DesCesar_ValueChanged(object sender, EventArgs e) {
			Abecedario abc = new Abecedario();
			int indice = 0;
             String texto = "";
            while(indice < TextoPlano.Text.Length)
			{
				if (abc.EsCaracter(TextoPlano.Text[indice]) == true)
				{
					texto = texto + cifrar.Cifrar(Convert.ToInt16(DesCesar.Value), Convert.ToChar(TextoPlano.Text[indice]));
				}
				else
				{
					texto = texto+TextoPlano.Text[indice] ;
				}

				indice++;
            }
            TextoCifrado.Text = texto;
            TextoInverso.Text = inverso.invertirCadena(TextoPlano.Text);
            
        }



        private void TextoPlano_TextChanged(object sender, EventArgs e){
            Cifrador cifrar = new Cifrador(); InvertirCadena inverso = new InvertirCadena();
            int indice = 0;
			Abecedario abc = new Abecedario();
			String texto = "";
			while (indice < TextoPlano.Text.Length)
			{
				if (abc.EsCaracter(TextoPlano.Text[indice]) == true)
				{
					texto = texto + cifrar.Cifrar(Convert.ToInt16(DesCesar.Value), Convert.ToChar(TextoPlano.Text[indice]));
				}
				else
				{
					texto = texto + TextoPlano.Text[indice];
				}

				indice++;
			}

			TextoCifrado.Text = texto;
            TextoInverso.Text = inverso.invertirCadena(TextoPlano.Text);
        }


        private void DesGrupo_ValueChanged(object sender, EventArgs e)
        {
            TextoInvertidoGrupo invertirxgrupo = new TextoInvertidoGrupo();
            /*//TextoInvertidoxGrupo.Text = invertirxgrupo.invertirCadena(TextoPlano.Text, 3);
			//TextoInvertidoxGrupo.Text = "h";
			TextoInvertidoxGrupo.Text = invertirxgrupo.invertirCadena(TextoPlano.Text,Convert.ToInt16(DesGrupo.Value));
			//Console.Write(invertirxgrupo.invertirCadena(TextoPlano.Text, 3));*/
           

            if(Convert.ToInt16(DesGrupo.Value)>=TextoPlano.Text.Length){
                TextoInvertidoxGrupo.Text = invertirGrupo(TextoPlano.Text, TextoPlano.Text.Length); ;
            }else{
                TextoInvertidoxGrupo.Text = invertirGrupo(TextoPlano.Text, Convert.ToInt16(DesGrupo.Value));
            }

        }

		private void TextoInvertidoxGrupo_TextChanged(object sender, EventArgs e)
		{
		//TextoInvertidoxGrupo.Text = "h";

		}
		//TextoInvertidoxGrupo.Text = textoinvertido.invertirCadena("hola", 3);


        public string invertirGrupo(string texto,int grup){

            string textoAux = " ";
            //string texto = "Hola Mundos";
            // alohnum 
            int tam = texto.Length;
            //int grup = 3;
            int i = 0;
            int f = grup;

            int contador = 0;
            while (contador < (tam / grup)){

                char[] charArray = texto.Substring(i, grup).ToCharArray();
                Array.Reverse(charArray);
                textoAux = textoAux + new string(charArray);
                i = i + grup;
                f = i;
                // grup*=2;
                contador++;
            }

            if (((tam / grup) % 2) != 0)
            {
                textoAux = textoAux + " " + texto.Substring((tam - 1), (grup - 1));
            }

            return textoAux;
        }

	}
}
