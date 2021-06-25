using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures2
{
    public class aBST
    {
        public int?[] Tree; // массив ключей
        private readonly int depth;

        public aBST(int depth)
        {
            // правильно рассчитайте размер массива для дерева глубины depth:
            this.depth = depth;

            var tree_size = (int) (Math.Pow(2, depth + 1) - 1);
            Tree = new int?[tree_size];
            for (var i = 0; i < tree_size; i++) Tree[i] = null;
        }

        public int? FindKeyIndex(int key)
        {
            // ищем в массиве индекс ключа
            var index = 0;
            var depthFind = 0;
            while (depthFind <= depth)
            {
                if (Tree[index] == null)
                {
                    return -index;
                }

                if (Tree[index] < key)
                {
                    index = RightChild(index);
                }
                else if (Tree[index] > key)
                {
                    index = LeftChild(index);
                }
                else
                {
                    return index;
                }

                depthFind++;
            }

            return null; // не найден
        }

        public int AddKey(int key)
        {
            // добавляем ключ в массив
            var index = FindKeyIndex(key);

            switch (index)
            {
                case null:
                    return -1;
                case < 0:
                    Tree[-index.Value] = key;
                    index = -index.Value;
                    break;
                case 0:
                    Tree[0] = key;
                    break;
            }
            
            return index.Value;
        }

        private static int Parent(int index)
        {
            return (index - 1) / 2;
        }

        private static int LeftChild(int index)
        {
            return 2 * index + 1;
        }

        private static int RightChild(int index)
        {
            return 2 * index + 2;
        }
    }
}