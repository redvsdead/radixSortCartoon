using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Обменная поразрядная сортировка символьного типа данных

namespace radixSortCartoon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sortButton.Enabled = false;
        }
        int size;
        char[] arr;

        private void genButton_Click(object sender, EventArgs e)
        {
            sortArr.Clear();
            randArr.Clear();
            Random rand = new Random();
            size = rand.Next(5, 19);
            arr = new char[size];
            for (int i = 0; i < size; ++i)
            {
                arr[i] = (char)rand.Next(65, 90);
                randArr.Text += arr[i] + "  ";
            }

            sortButton.Enabled = true;
        }


        //range -- система счисления (к-во цифр, из которых может состоять код символа, я беру десятичную систему), 
        //length -- длина наибольшего кода (символы от A до Z, поэтому все коды не превышают 99)
        //можно было бы взять 16-тиричные коды unicode, но тогда понадобится 16 массивов и итераций будет больше
        public static void sorting(char[] arr, int range, int maxLength)
        {
            ArrayList[] lists = new ArrayList[range];   //здесь хранятся списки элементов (по цифре 0, 1 и тд до 9 в рассматриваемом разряде)
            for (int i = 0; i < range; ++i)
                lists[i] = new ArrayList();

            for (int bitNum = 0; bitNum < maxLength; ++bitNum)
            {
                //распределение по спискам от 0 до 9
                for (int i = 0; i < arr.Length; ++i)
                {
                    //выделяем цифру на текущей позиции из номера символа и кладем символ в список
                    int temp = ((int)arr[i] % (int)Math.Pow(range, bitNum + 1)) / (int)Math.Pow(range, bitNum);
                    lists[temp].Add(arr[i]);
                }
                //сборка массива поразрядно
                int k = 0;
                for (int i = 0; i < range; ++i)
                {
                    for (int j = 0; j < lists[i].Count; ++j)
                    {
                        arr[k++] = (char)lists[i][j];
                    }
                }
                for (int i = 0; i < range; ++i)
                    lists[i].Clear();   //очистка списков элементов по разрядам
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            sortArr.Clear();
            sorting(arr, 10, 2);
            for (int i = 0; i < size; ++i)
            {
                sortArr.Text += arr[i] + "  ";
            }
        }
    }
}
