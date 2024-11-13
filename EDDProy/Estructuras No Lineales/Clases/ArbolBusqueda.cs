using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        NodoBinario Raiz;
        public String strArbol;
        public String strRecorrido;

        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = "";
            strRecorrido = "";
        }

        public Boolean EstaVacio()
        {
            if (Raiz == null)
                return true;
            else
                return false;
        }
        public NodoBinario RegresaRaiz()
        {
            return Raiz;
        }

        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {            
            if (Nodo == null)
            {
                Nodo = new NodoBinario(Dato);
                // CAMBIO 2

                if (Raiz == null)
                    Raiz = Nodo;
            }

            else if (Dato < Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Izq);
            else if (Dato > Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Der);          
        }
        public void MuestraArbolAcostado(int nivel, NodoBinario nodo )
        {
            if (nodo == null)
                return;
            MuestraArbolAcostado(nivel + 1, nodo.Der);
            for(int i=0; i<nivel; i++)
            {
                strArbol = strArbol + "      ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            MuestraArbolAcostado(nivel + 1, nodo.Izq);
        }

        public  String ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [side=L] {2} ", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            }
            return b.ToString();
        }

        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            strRecorrido = strRecorrido + nodo.Dato + ", ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);
            
            return;
        }

        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            InOrden(nodo.Izq);
            strRecorrido = strRecorrido + nodo.Dato + ", ";
            InOrden(nodo.Der);

            return;
        }
        public void PostOrden(NodoBinario nodo )
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + ", ";

            return;
         }

        public bool BuscarNodo(int Dato, NodoBinario nodo)
        {
            if (nodo == null)
                return false;

            if (nodo.Dato == Dato)
                return true;

            else if (Dato < nodo.Dato)
                return BuscarNodo(Dato, nodo.Izq);
            else
                return BuscarNodo(Dato, nodo.Der);
        }

        public void PodarArbol(ref NodoBinario nodo)
        {
            if (nodo == null)
                return;            
            PodarArbol(ref nodo.Izq);          
            PodarArbol(ref nodo.Der);     
            nodo = null;
        }

        public void PodarArbolCompleto()
        {
            if (Raiz == null)
            {
                Console.WriteLine("Arbol vacio");
                return;
            }
            PodarArbol(ref Raiz); 
            Raiz = null; 
            Console.WriteLine("El arbol ha sido podado por completo");
        }

        public bool EliminarPredecesor(int valor)
        {
            return EliminarPredecesor(valor, ref Raiz);
        }

        private bool EliminarPredecesor(int valor, ref NodoBinario nodo)
        {
            if (nodo == null)
            {
                return false;
            }
            else if (valor < nodo.Dato)
            {
                return EliminarPredecesor(valor, ref nodo.Izq);
            }
            else if (valor > nodo.Dato)
            {
                return EliminarPredecesor(valor, ref nodo.Der);
            }
            else
            {              
                if (nodo.Izq != null && nodo.Der != null)
                {                
                    NodoBinario predecesor = BuscarMayor(nodo.Izq);
                    nodo.Dato = predecesor.Dato;
                    return EliminarPredecesor(predecesor.Dato, ref nodo.Izq);
                }
                else
                {
                    NodoBinario temp = nodo;
                    nodo = (nodo.Izq != null) ? nodo.Izq : nodo.Der;
                    temp = null;
                    return true;
                }
            }
        }
        private NodoBinario BuscarMayor(NodoBinario nodo)
        {
            while (nodo.Der != null)
            {
                nodo = nodo.Der;
            }
            return nodo;
        }

        public bool EliminarSucesor(int dato)
        {
            return EliminarSucesor(dato, ref Raiz);
        }

        private bool EliminarSucesor(int dato, ref NodoBinario nodo)
        {
            if (nodo == null)
                return false;
            else if (dato < nodo.Dato)
                return EliminarSucesor(dato, ref nodo.Izq);
            else if (dato > nodo.Dato)
                return EliminarSucesor(dato, ref nodo.Der);
            else
            {
                if (nodo.Izq != null && nodo.Der != null) // Tiene dos hijos
                {
                    NodoBinario menor = BuscarMenor(nodo.Der);
                    nodo.Dato = menor.Dato;
                    return EliminarSucesor(menor.Dato, ref nodo.Der);
                }
                else
                {
                    NodoBinario temp = nodo;
                    nodo = (nodo.Izq != null) ? nodo.Izq : nodo.Der;
                    temp = null;
                    return true;
                }
            }
        }

        private NodoBinario BuscarMenor(NodoBinario nodo)
        {
            while (nodo.Izq != null)
            {
                nodo = nodo.Izq;
            }
            return nodo;
        }
        public void Amplitud(NodoBinario nodoRaiz)
        {
            if (nodoRaiz == null)
            {
                Console.WriteLine("El arbol esta vacio");
                return;
            }

            Colas colaAuxiliar = new Colas();
            colaAuxiliar.Enqueue(nodoRaiz); 

            while (!colaAuxiliar.IsEmpty())
            {
            
                NodoBinario nodoActual = (NodoBinario) colaAuxiliar.Dequeue();
              
                Console.WriteLine(nodoActual.Dato);
            
                if (nodoActual.Izq != null)
                {
                    colaAuxiliar.Enqueue(nodoActual.Izq);
                }

                if (nodoActual.Der != null)
                {
                    colaAuxiliar.Enqueue(nodoActual.Der);
                }
            }
        }

        public int CalcularAltura(NodoBinario nodo)
        {
            if (nodo == null)
                return 0;

            int alturaIzquierda = CalcularAltura(nodo.Izq);
            int alturaDerecha = CalcularAltura(nodo.Der);

            return Math.Max(alturaIzquierda, alturaDerecha) + 1;
        }

        public int ContarHojas(NodoBinario nodo)
        {       
            if (nodo == null)
                return 0;
       
            if (nodo.Izq == null && nodo.Der == null)
                return 1;
          
            return ContarHojas(nodo.Izq) + ContarHojas(nodo.Der);
        }

        public int ContarNodos(NodoBinario nodo)
        {         
            if (nodo == null)
                return 0;
            
            return 1 + ContarNodos(nodo.Izq) + ContarNodos(nodo.Der);
        }

        public bool EsCompleto(NodoBinario nodoPtr)
        {
            if (nodoPtr == null)
                return true;
            
            Colas colaAuxiliar = new Colas();
            colaAuxiliar.Enqueue(nodoPtr);  
            bool nodoNolleno = false; 
            while (!colaAuxiliar.IsEmpty())  
            {              
                NodoBinario nodoActual = (NodoBinario)Convert.ChangeType(colaAuxiliar.Dequeue(), typeof(NodoBinario));             
                if (nodoActual.Izq != null)
                {
                    if (nodoNolleno)
                        return false;  
                    colaAuxiliar.Enqueue(nodoActual.Izq);  
                }
                else
                {
                    nodoNolleno = true;  
                }
                
                if (nodoActual.Der != null)
                {
                    if (nodoNolleno)
                        return false;  
                    colaAuxiliar.Enqueue(nodoActual.Der);  
                }
                else
                {
                    nodoNolleno = true;  
                }
            }
            return true;
        }

        public bool esLleno(NodoBinario nodo)
        {         
            if (nodo == null)
                return true;      
            if (nodo.Izq == null && nodo.Der == null)
                return true;
            if (nodo.Izq != null && nodo.Der != null)
                return esLleno(nodo.Izq) && esLleno(nodo.Der);
            return false;
        }
    }
}
