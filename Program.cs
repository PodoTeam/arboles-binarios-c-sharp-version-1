using System;
namespace arbol001
{
    class Nodo
    {
        public int data;
        public Nodo izquierdo;
        public Nodo derecho;
        public Nodo()
        {
            data = 0;
            izquierdo = null;
            derecho = null;
        }
    }
    class Arbol
    {
        public Nodo raiz;
        public Arbol()
        {
            raiz = null;
        }
        public void SetNode(int data)
        {
            raiz = SetNode(raiz, data);
        }
        //public bool EsHermano (Nodo p)
        //{

        //}
        //public Nodo Padre (Nodo p)
        //{

        //} 
        //public bool EsIzquierdo (Nodo p)
        //{
        //    Nodo q;
        //    q = Padre(p);
        //    if (q == null)
        //        return false; // p apunta a la raiz 
        //    else
        //        if (Izquierdo(q) == p)
        //        return true;
        //    return false;
        //}

        //public bool EsDerecho (Nodo p)
        //{

        //}
        //public Nodo Izquierdo(Nodo p)
        //{
        //    return p.izquierdo;
        //}
       
        public Nodo SetNode(Nodo p, int x)
        {
            if (p == null)
            {
                p = new Nodo();
                p.data = x;
            }
            else
            {
                if (p.izquierdo == null)
                {
                    p.izquierdo = SetNode(p.izquierdo, x);
                }
                else
                {
                    p.derecho = SetNode(p.derecho, x);
                }
            }
            return p;
        }

        public void Imprimir()
        {
            Imprimir(raiz, 4);
        }

        public void Imprimir(Nodo p, int padding)
        {
            if (p != null)
            {
                if (p.derecho != null)
                {
                    Imprimir(p.derecho, padding + 4);
                }
                if (padding > 0)
                {
                    Console.Write(" ".PadLeft(padding));
                }
                if (p.derecho != null)
                {
                    Console.Write("/\n");
                    Console.Write(" ".PadLeft(padding));
                }
                Console.Write(p.data.ToString() + "\n ");
                if (p.izquierdo != null)
                {
                    Console.Write(" ".PadLeft(padding) + "\\\n");
                    Imprimir(p.izquierdo, padding + 4);
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo Árbol Binario");
            int[] nodeData = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            Arbol arbol1 = new Arbol();
            foreach (int i in nodeData)
            {
                arbol1.SetNode(i);
            }
            arbol1.Imprimir();
            Console.ReadKey();
            Console.WriteLine("Ejemplo 2 Árbol Binario");
            Arbol arbol2 = new Arbol();

            arbol2.SetNode(nodeData[1]);
            //arbol2.SetDerecho(arbol2.raiz, nodeData[2]);
            //arbol2.SetIzquierdo(arbol2.raiz, nodeData[3]);

            arbol2.Imprimir();
            /*
         * cree el código necesario para ingresar por teclado datos para construir un Árbol Binario
         * y seleccionar si se desea colocar el dato a la izquierda o a la derecha del árbol
         * los datos se ingresarán siempre como hojas del Árbol considerando el ultimo nodo padre y si es mayor que ese nodo 
         * colocarlo como hijo derecho pero si es menor colocarlo como hijo izquierdo
        */
        }
    }
}

