using System;
using LSPLibrary;

namespace LSP
{
    class Program
    {
        /*Criticas:
            --LSP--
            Debería de haber una interfáz que contenga las operaciones para las distintas
            plataformas con las que se va a interactuar.
            Estas plataformas se implementarán de forma distinta, pero en base a la misma
            interfáz.

            --Polimorphic--
            Por otro lado, creemos que los métodos dentro de Alert y Events deben ser
            polimórficas ya que para todas las distintas plataformas, se necesitan los 
            mismos métodos pero con implementaciones distintas.
        
        */
        static void Main(string[] args)
        {
            // Lanzamos un evento informativo que se notificará
            // solamente por consola
            RaiseInformationEvent("Temperature is 36.8 degrees");

            // Lanzamos un evento severo que se notificará por
            // consola y en el board de Trello
            RaiseSevereEvent("Heart rate is below 60");
        }

        private static void RaiseInformationEvent(string eventName)
        {
            // Usamos el nombre "_event" porque "event" es una keyword.
            EventTrello _event = new EventTrello();
            _event.EventType = "information";
            _event.EventName = eventName;
            _event.Notify();
        }

        private static void RaiseSevereEvent(string eventName)
        {
            // Usamos el nombre "_event" porque "event" es una keyword.
            EventTrello _event = new EventTrello();
            _event.EventType = "severe";
            _event.EventName = eventName;
            _event.Notify();
        }
    }
}
