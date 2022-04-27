#include<16f887.h>
#fuses INTRC_IO,NOWDT,PROTECT,NOLVP,MCLR,NOBROWNOUT
#device ADC=8
#use delay(INTERNAL=4000000)
#use RS232(baud=9600,xmit=PIN_C6,rcv=PIN_C7,timeout=100)   //Inicialización del puerto serie en el uC
                  //Baudaje: 9600, Transmisor (Tx): RC6, Receptor (Rx): RC7
#include"lcd.h"

void main()
{
   int16 variable; //Declaramos variable entera que guarda lo que capture el ADC y la terminal virtual 
   float voltaje; // Declaramos variables de punto flotante para el calculo de voltaje y angulo
   float angulo;
   lcd_init();  //Inicializamos el LCD
   setup_adc_ports(sAN0); //Instruccion para configurar los pines como entradas analogicas
   setup_adc(ADC_CLOCK_INTERNAL); //Utilizamos el reloj interno para generar una frecuencia de muestreo  
  while(true)
   {
      variable=read_adc(); //Funcion que nos permite obtener el valor del ADC y terminal virtual  y retorna valor adimensional 
      angulo = (float)variable*270/255;
      voltaje = (float)variable*5/255; //Aplicamos regla de tres tanto para el angulo como voltaje y guardamos el valor entero de iAdc como un valor float      
      printf(lcd_putc, "\fvoltaje %1.2f",voltaje);  //Agrgamos el valor de voltaje con un entero y dos de punto flotante
      printf(lcd_putc, "\nangulo %3.2f",angulo);
      delay_ms(100); 
      printf("%Lu,%1.2f,%3.2f\n\r", variable, voltaje, angulo);
      
      /*
      //------------------------------------------------------------------------------------------------------------
      //Terminal Virtual
      printf("Numero: %Lu\n\r", variable);  
      printf("Voltaje: %1.2f\n\r", voltaje);
      printf("Angulo: %1.2f\n\r", angulo);
      delay_ms(100);  */
   }
}
