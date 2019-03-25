using System;

namespace isen.DotNet.Library.Lists
{
    public class MyCollection
    {
        private string[] _values;

        public MyCollection()
        {
            _values = new string[0];
        }

        public int Count => _values.Length;

        public string[] Values => _values;

        /// <summary>
        /// Accesseur Indexeur
        /// </summary>
        /// <value></value>
        public string this[int index]
        {
            get { return _values[index]; }
            set { _values[index] = value; }
        }

        /// <summary>
        /// Ajoute un élément à la fin de la liste
        /// </summary>
        /// <param name="item"></param>
        public void Add(string item)
        {
            //Nouveau tableau de taille + 1
            var tmp = new string[Count + 1];
            //copier les éléments du tableau initial
            for (int i = 0 ; i < Count; i ++)
            {
                tmp[i] = _values[i];
            }
            //Ajout du nouvel élément
            tmp[Count] = item;
            //Echange des tableau
            _values = tmp;
        }

        public void RemoveAt(int index)
        {
            if(Values?.Length == 0 
                || index > Count
                || index < 0)
                throw new IndexOutOfRangeException();

            //Nouveau tableau de taille - 1
            var tmp = new string[Count - 1];
            //copier les éléments du tableau initial
            for (int i = 0 ; i < Count-1; i ++)
            {
                tmp[i] = _values[i < index ? i : i + 1];
            }
            //Echange des tableau
            _values = tmp;
        }


    }
}