using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class DynamicArray<T>
    {
        T[] data;
        T[] Vector;
        int count;
        object[] array;
        public T[] arr;

        public DynamicArray(IEnumerable<T>sourse)
        {
            arr = sourse.ToArray();
        }

        public DynamicArray()
        {
            array = new object[8];
        }

        public DynamicArray(int length)
        {
            array = new object[length];
        }

        public DynamicArray(T[] array)
        {
            array = new T[10];
        }

        public void Add(T elem)
        {
            if (data.Length == count)
            {
                data[count++] = elem;
            }

        }
        public T AddRange(T elem, int index)
        {
            T a = Vector[index];
            T b;
            T c;
            try { b = Vector[index + 1]; }
            catch { return default(T); }

            try { c = Vector[index + 2]; }
            catch { return default(T); }


            int i = index;
            for (; i != Vector.Length; i++)
            {
                Vector[i + 1] = a;
                a = b;
                b = c;
                try { a = Vector[i + 3]; }
                catch { break; }
            }
            Vector[index] = elem;
            count++;
            return default(T);
        }

        public void RemoveAt(int index)
        {
            int picOut = index + 1;
            if (picOut < count)
            {
                Array.Copy(data, picOut, data, index, count - picOut);
                count--;
            }

        }
        public bool Remove(T elem, int index)
        {
            for (int i = 0; i < count; i++)
            {
                if (data[i].Equals(elem))
                {
                    RemoveAt(i);
                    return true;
                }

            }
            return false;
        }

        public void GrowArray()
        {
            int newLength = data.Length == 0 ? (data.Length * 3) / 2 + 1 : data.Length << 1;
            T[] newArray = new T[newLength];
            data.CopyTo(newArray, 0);
            data = newArray;
        }
        public void Insert(T elem, int index)
        {
            if (data.Length == this.count)
            {
                this.GrowArray();
            }
            Array.Copy(data, index, data, index + 1, count - index);
            data[index] = elem;
            count++;

        }
    }


}