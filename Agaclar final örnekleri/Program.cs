using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Agaclar_final_örnekleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ÖR:(15)
                  /   \
                 /     \
              (11)     (26)
             /   \     /   \
            /     \   /     \
           (8)  (12) (20)  (30)
          /  \   \           \
         /    \   \           \
        (6)  (9)  (14)        (35)  şeklinde bir binary treemiz olsun.

             */


            binarytree[0] = 15;
            binarytree[1] = 11;
            binarytree[2] = 26;
            binarytree[3] = 8;
            binarytree[4] = 12;
            binarytree[5] = 20;
            binarytree[6] = 30;
            binarytree[7] = 6;
            binarytree[8] = 9;
            binarytree[9] = 120;
            binarytree[10] = 14;
            binarytree[11] = 15;
            binarytree[12] = 2;
            binarytree[13] = 5;
            binarytree[14] = 35;

            // boş notlara 0 atamazsak yanlış yapar
            // yaz(binarytree, 0);
            //MyBinaryTree a = new MyBinaryTree();
            //a = ders8(binarytree, 0, ref head);
            //ders9(head);

            //int varmı = ara(binarytree, 0, 35);
            //Console.WriteLine(varmı);


            //tekrar(binarytree, 0, 14);
            //Console.WriteLine(sayaç);


            //int sonuç = search(a,238);
            //Console.WriteLine(sonuç);
            //for (int i = 0; i < binarytree.Length; i++)
            //{   
            //    if (binarytree[i] != 0)
            //    stack.Push(binarytree[i]);

            //}

            //yazdır(binarytree, 0);
            //int[] bosdizi = new int[100];
            //int[] array = { 8, 3, 10, 1, 6, 14, 4, 7, 13 };
            //soru6(array, 0, bosdizi);
            //yaz(bosdizi, 0);


            //int toplam = toplamNodeBul(binarytree, 0);
            //Console.WriteLine(sayı);

            int max = maxbul(binarytree, 0);
            Console.WriteLine(max);

            //int seviye2maxı = ders3(binarytree, 0, 0);
            //Console.WriteLine(derinlik(binarytree,0));
            //Console.WriteLine(bul(binarytree,0));
            // treeyaz(binarytree, 0);
            // Console.WriteLine( toplambul(binarytree, 0));
            //Console.WriteLine(derinlikbul(binarytree,0));
            //Console.WriteLine(derinlik(binarytree, 0));
            Console.ReadLine();
        }
        static int value = 0;
        static int toplambul(int[] btree, int index)
        {
            if (index >= btree.Length) return 0;
            toplambul(btree, index * 2 + 1);
            toplambul(btree, index * 2 + 2);
            value += btree[index];
            return value;
        }
        static void treeyaz(int[] btree, int index)
        {
            if (index >= 14) return;
            treeyaz(btree, index * 2 + 2);
            treeyaz(btree, index * 2 + 1);
            Console.WriteLine(btree[index]);

        }
        static int sayı = 1;
        static int toplamNodeBul(int[] bt, int indis)
        {
            if (indis >= bt.Length) return 0;
            if (bt[indis] == 0) return 0;
            else sayı++;
            //int a = 1 + toplamNodeBul(bt, indis * 2 + 1);
            //int b = 1 + toplamNodeBul(bt, indis * 2 + 2);
            return toplamNodeBul(bt, indis * 2 + 1) + toplamNodeBul(bt, indis * 2 + 2);
        }
        // ilk önce dizilerle binary tree kodlayalım
        static int[] binarytree = new int[15];
        static void yaz(int[] bt, int indis)
        {

            if (indis >= bt.Length) return;
            // if (bt[indis] != 0)
            //Console.WriteLine(bt[indis]);
            //yaz(bt, indis * 2 + 1);// treenin solundaki elemanları yazdırır
            //yaz(bt,indis * 2 + 2);// treenin sağındaki elemanları yazdırır
            ///////////////////////////////////////////////
            if (bt[indis] != 0)
            {
                yaz(bt, indis * 2 + 1);
                Console.WriteLine(bt[indis]); //önce sol nodelar sonra kök sonra sag nodelar yazılır
                yaz(bt, indis * 2 + 2);
            }
            ///////////////////////////////////////////////
            //if (bt[indis] != 0)
            //{
            //    yaz(bt, indis * 2 + 1);
            //    yaz(bt, indis * 2 + 2);
            //    Console.WriteLine(bt[indis]); // sırayla sol sag ve kök yazılır
            //}
        }
        // linled listlerle kodlamasına geçelim
        //static Blocktree olustur(int[] bt, int indis)
        //{
        //    if (indis >= bt.Length) return null;
        //    if (bt[indis] != 0)
        //        Console.WriteLine(bt[indis]);
        //    Blocktree bnt = new Blocktree();
        //    bnt.data = bt[indis];
        //    indis = indis * 2 + 1;
        //    bnt.left = olustur(bt, indis);
        //    bnt.right = olustur(bt,indis+1);
        //    return bnt;
        //}
        /*
        1-)Binary treede bir elemanın olup olmadığını buldur.(hem normal hem recursive çöz)
        2-)Binary treede bir elemanın kaç kez tekrar ettiğini buldur.(hem normal hem recursive çöz)
        3-)Linked list ile oluşturulmuş bir binarytree'de search yap.(recursive)
        4-)Linked listle oluşturulmuş bir tree'yi diziye aktar.
        5-)Binarytree'nin elemanlarını stacklarla yazdır.
        6-)Sırasız elemanları bulunan bir diziyi sıralı şekilde tree'ye aktar.*/
        static int a1 = 0;
        static int bul(int[] bt, int indis)
        {
            if (indis >= bt.Length) return 0;
            bul(bt, indis * 2 + 1);
            bul(bt, indis * 2 + 2);
            a1++;
            return a1;
        }
        static int derinlik(int[] bt, int indis)
        {
            int a = 0;
            int b = 0;
            int c = indis * 2 + 1;
            if (c < bt.Length)
                if (bt[c] > 0)
                    a = 1 + derinlik(bt, c);
            c++;
            if (c < bt.Length)
                if (bt[c] > 0)
                    b = 1 + derinlik(bt, c);

            if (a > b) return a; else return b;
        }
        static Stack<int> stack = new Stack<int>();
        static void yazdır(int[] bt, int indis)
        {
            // 5 -)Binarytree'nin elemanlarını stacklarla yazdır.
            if (indis >= bt.Length) return;
            if (bt[indis] != 0)
                Console.WriteLine(stack.Pop());
            yazdır(bt, indis * 2 + 1);
            yazdır(bt, indis * 2 + 2);
        }
        static void soru6(int[] dizi, int indis, int[] bt)
        {
            if (indis >= dizi.Length) return;
            if (bt[indis] == 0)
            {
                bt[indis] = dizi[indis];
            }
            soru6(dizi, indis + 1, bt);

        }
        static int derinlikbul(int[] btree, int index)
        {
            int a = 0;
            int b = 0;
            if (index >= btree.Length) return 0;
            if (index * 2 + 1 < btree.Length)
            {
                a = 1 + derinlikbul(btree, index * 2 + 1);
            }
            if (index * 2 + 2 < btree.Length)
            {
                b = 1 + derinlikbul(btree, index * 2 + 2);
            }
            if (a > b) return a; else return b;
        }
        static int ders3(int[] bt, int indis, int seviye)
        { // search yapalım
            if (indis >= bt.Length) return 0;


            if (seviye == 2) if (bt[indis] > 0) return bt[indis];
                else return 0;

            int a = ders3(bt, indis * 2 + 1, seviye + 1);
            int b = ders3(bt, indis * 2 + 2, seviye + 1);
            if (a > b) return a; else return b;

        }
        static int maxbul(int[] bt, int indis)
        {
            if (indis >= bt.Length) return 0;

            int a = maxbul(bt, indis * 2 + 1);
            int b = maxbul(bt, indis * 2 + 2);
            int c = 0;
            if (a > b) c = a; else c = b;
            if (bt[indis] > c) c = bt[indis];
            return c;
        }
        static int ara(int[] bt, int indis, int aranan)
        {
            //1-)Binary treede bir elemanın olup olmadığını buldur.(hem normal hem recursive çöz)
            if (indis >= bt.Length) return 0;
            //if (bt[indis] <aranan) return ara(bt,indis*2+2,aranan);
            //else if (bt[indis] == aranan) return 1;
            //else
            //    return ara(bt,indis*2+1,aranan);

            if (bt[indis] == aranan) return 1;
            return ara(bt, indis * 2 + 1, aranan) + ara(bt, indis * 2 + 2, aranan);


        }
        static int sayaç = 0;
        static int tekrar(int[] bt, int indis, int aranan)
        {
            // 2-)Binary treede bir elemanın kaç kez tekrar ettiğini buldur
            if (indis >= bt.Length) { return 0; }
            if (bt[indis] == aranan)
                sayaç++;
            return tekrar(bt, indis * 2 + 1, aranan) + tekrar(bt, indis * 2 + 2, aranan);

        }
        static int[] dizi = new int[100];
        static void aktar(MyBinaryTree bt, int indis, int[] dizi)
        {
            //4-)Linked listle oluşturulmuş bir tree'yi diziye aktar.
            if (bt == null) return;
            dizi[indis] = bt.data;
            aktar(bt.left, indis * 2 + 1, dizi);
            aktar(bt.right, indis * 2 + 2, dizi);
        }
        static int search(MyBinaryTree bt, int aranan)
        {
            // 3 -)Linked list ile oluşturulmuş bir binarytree'de search yap.(recursive)
            if (bt == null) return 0;
            if (bt.data == aranan) return 1;
            return search(bt.left, aranan) + search(bt.right, aranan);
        }

        static MyBinaryTree ders8(int[] bt, int indis, ref MyBinaryTree btl)
        {// Linked List ile binary tree oluşturmak
            if (indis >= bt.Length) return null;
            MyBinaryTree tmp = new MyBinaryTree();
            tmp.data = bt[indis];
            if (btl == null) btl = tmp;
            tmp.left = ders8(bt, indis * 2 + 1, ref btl);
            tmp.right = ders8(bt, indis * 2 + 2, ref btl);
            return tmp;
        }
        static MyBinaryTree head = null;
        static void ders9(MyBinaryTree mbt)
        {
            // linked List ile yazdırma işlemi
            if (mbt == null) return;

            ders9(mbt.left);
            if (mbt.data != 0) Console.WriteLine(mbt.data);
            ders9(mbt.right);
        }

        static int x(int[] bt, int indis, int seviye)
        {
            if (indis >= bt.Length) return 0;
            if (seviye == 2) if (bt[indis] >0)return bt[indis];

            int sol = x(bt, indis * 2 + 1, seviye + 1);
            int sag = x(bt, indis * 2 + 2, seviye + 1);
            if (sol > sag) return sol; else return sag;
        }


    }
    class MyBinaryTree
    {
        public int data;
        public MyBinaryTree left;
        public MyBinaryTree right;
    }

}
