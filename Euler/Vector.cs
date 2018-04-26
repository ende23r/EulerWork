using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /*
     * Implements a resizable array of homogenous data.
    */
    public class Vector<T> {
        private T[] arr;
        private int used;
        private int capacity;

        public Vector() {
            capacity = 10;
            arr = new T[capacity];
            used = 0;
        }

        public void Append(T item) {
            if (used >= capacity) {
                capacity *= 2;
                var temp = new T[capacity];

                Array.Copy(arr, temp, arr.Length);
                arr = temp;
            }
            arr[used++] = item;
        }

        public T Retreive(int index) {
            if (index < used) {
                return arr[index];
            }
            //else throw exception
            return default(T);
        }
    }
}
