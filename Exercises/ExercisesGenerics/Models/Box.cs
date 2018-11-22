using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ExercisesGenerics
{
    using Interfaces;
    using System.Linq;

    public class Box<T> : IIntOrString
        where T : IComparable<T>
    {
        private IList<T> data;
        private T element;

        public Box()
        {
            this.data = new List<T>();
        }

        public Box(T element)
            : this()
        {
            this.element = element;
        }

        public IList<T> Data => this.data;

        public void Add(T element)
        {
            this.data.Add(element);
        }

        public int CompareElement(T someElement)
        {
            var counter = 0;

            foreach (var element in this.data)
            {
                if (someElement.CompareTo(element) < 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            var firstElement = this.data[firstIndex];
            data[firstIndex] = data[secondIndex];
            data[secondIndex] = firstElement;

        }

        public void Remove(int elementRemove)
        {
            this.Data.RemoveAt(elementRemove);
        }

        public void Print()
        {
            foreach (var item in this.data)
            {
                Console.WriteLine(item);
            }
        }

        public string Contains(T element)
        {
            if (this.Data.Contains(element))
            {
                return "True";
            }

            return "False";
        }

        public string Max()
        {
            var max = this.data.Max();
            return max.ToString();
        }

        public string Min()
        {
            var min = this.data.Min();
            return min.ToString();
        }

        public void Sort()
        {
            this.data = this.data
                 .OrderBy(x => x)
                 .ToArray();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var element in this.data)
            {
                sb.AppendLine($"{element.GetType().FullName}: {element}");
            }

            return sb.ToString().Trim();
        }
    }
}
