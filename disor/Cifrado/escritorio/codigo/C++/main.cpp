#include "mainwindow.h"
#include <QApplication>
//#include <iostream.h>
//#include <conio.h>
#include <stdio.h>
#include <string.h>



 void imprime(std::string texto,int tam){
     for(int i=0;i<tam; i++){
         printf("%c",texto[i]);
     }

 }

void prueba( std::string texto ){
 //char texto[]={texto2};
        int desp=1,tam,aux;

        //texto="jose";

        //tam=strlen(texto);
        tam=texto.length();

        for(int i=0;i<tam;i++){
          aux=texto[i];
          if(aux+desp>122) {
             aux=((aux+desp)-122)+96;
          }else{
              aux=aux+desp;
          }
          if(texto[i]!=' '){
             texto[i]=aux;
          }
        }

        imprime(texto,tam);

}



int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    MainWindow w;
    //w.setName("Slim Shady");
    //w.setName(w.getName());

    //texto[3]=w.getName();
    std::string cadenaStd = w.getName().toStdString();

    w.show();

    return a.exec();
}
