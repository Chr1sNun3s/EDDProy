using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmos_de_busqueda.Clases
{
    public class Hash
    {
        private readonly int _tam;
        private readonly LinkedList<KeyValuePair<int, string>>[] _tabla;
        public Hash(int tam)
        {
            _tam = tam;
            _tabla = new LinkedList<KeyValuePair<int, string>>[tam];

            for (int i = 0; i < tam; i++)
            {
                _tabla[i] = new LinkedList<KeyValuePair<int, string>>();
            }
        }
        public void Ingresar(int key, string value)
        {
            int index = HashFunction(key);

            foreach (var pair in _tabla[index])
            {
                if (pair.Key == key)
                {
                    throw new Exception("La clave ya existe en la tabla hash.");
                }
            }

            _tabla[index].AddLast(new KeyValuePair<int, string>(key, value));
        }      
        public string Buscar(int key)
        {
            int index = HashFunction(key);

            foreach (var pair in _tabla[index])
            {
                if (pair.Key == key)
                {
                    return pair.Value;
                }
            }

            return "No encontrado";
        }
        private int HashFunction(int key)
        {
            return key % _tam;
        }
    }
}
