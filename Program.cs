using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Motor v8 = new Motor("v8");
            Motor v9 = new Motor("v9");
            Acelerador x = new Acelerador();

            x.enlazarObservador(v8);
            x.enlazarObservador(v9);

            x.pisarAcelerador();


            Console.ReadKey();
        }
    }

    class Motor : Observador
    {
        private String name;
        public Motor(String name) { this.name = name; }

        public String getName() { return this.name; }

        public void update()
        {
            Console.WriteLine(name + " - Subiendo la velocidad");
        }
    }

    class Acelerador : SujetoObservable
    {
        private List<Observador> observadores;

        public Acelerador() { observadores = new List<Observador>(); }

        public void enlazarObservador(Observador o) { observadores.Add(o); }

        public void pisarAcelerador()
        {
            notificar();
        }

        public void notificar()
        {
            observadores.ForEach((observer) => {
               observer.update();
            });
        }
    }
}
