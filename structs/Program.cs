﻿using data_structs.Arvore;
using data_structs.Node;
using System;

namespace data_structs
{
    class Program
    {
        static void Main(string[] args)
        {
            //NoBinary root = new NoBinary(null, 10);
            //SearchBinaryTree searchTree = new SearchBinaryTree(root);

            //searchTree.insert(root, 5);
            //searchTree.insert(root, 2);
            //searchTree.insert(root, 8);
            //searchTree.insert(root, 15);
            //searchTree.insert(root, 22);
            //searchTree.insert(root, 25);

            //searchTree.showTree(root);

            NoBinary root = new NoBinary(null, 10);
            TreeAVL searchTree = new TreeAVL(root);

            searchTree.insertAVL(root, 5);
            searchTree.insertAVL(root, 2);
            searchTree.insertAVL(root, 8);
            searchTree.insertAVL(root, 15);
            searchTree.insertAVL(root, 22);
            searchTree.insertAVL(root, 25);
            searchTree.insertAVL(root, 27);
            searchTree.insertAVL(root, 30);

            searchTree.showTree(root);

            //while (true)
            //{
            //    Console.WriteLine("Escolha uma ação");
            //    Console.WriteLine("Digite 1 para inserir / Digite 2 para remover");
            //    int choice = int.Parse(Console.ReadLine());
            //    if (choice == 1)
            //    {
            //        Console.WriteLine("Insira um novo valor na arvore!");
            //        int value = int.Parse(Console.ReadLine());
            //        searchTree.insert(root, value);

            //        Console.Clear();
            //    } else if(choice == 2)
            //    {
            //        Console.WriteLine("Insira o elemento que você quer remover da arvore!");
            //        int value = int.Parse(Console.ReadLine());
            //        //searchTree.remove(searchTree.search(root, value), value);

            //        Console.Clear();
            //    }

            //    searchTree.showTree(searchTree.getRoot());

            //    Console.ReadKey();

            //    Console.Clear();
            //}
        }
    }
}
