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
using System.Threading;

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
        public static void sorting(char[] arr, int range, int maxLength, 
                                   TextBox zero, TextBox one, TextBox two, TextBox three, TextBox four, 
                                   TextBox five, TextBox six, TextBox seven, TextBox eight, TextBox nine, 
                                   TextBox currArr)
        {
            ArrayList[] lists = new ArrayList[range];   //здесь хранятся списки элементов (по цифре 0, 1 и тд до 9 в рассматриваемом разряде)
            for (int i = 0; i < range; ++i)
                lists[i] = new ArrayList();

            int pow = 1;    //степень, нужная для вычисления текущего символа
            for (int digNum = 0; digNum < maxLength; ++digNum)
            {
                //распределение по спискам от 0 до 9
                for (int i = 0; i < arr.Length; ++i)
                {
                    //выделяем цифру на текущей позиции из номера символа и кладем символ в список
                    int temp = ((int)arr[i] % (pow * range)) / pow;
                    lists[temp].Add(arr[i]);
                }
                pow *= range;
                zero.Clear();
                one.Clear();
                two.Clear();
                three.Clear();
                four.Clear();
                five.Clear();
                six.Clear();
                seven.Clear();
                eight.Clear();
                nine.Clear();

                for (int j = 0; j < lists[0].Count; ++j)
                {
                    zero.Text += (char)lists[0][j] + " ";
                }

                for (int j = 0; j < lists[1].Count; ++j)
                {
                    one.Text += (char)lists[1][j] + " ";
                }

                for (int j = 0; j < lists[2].Count; ++j)
                {
                    two.Text += (char)lists[2][j] + " ";
                }

                for (int j = 0; j < lists[3].Count; ++j)
                {
                    three.Text += (char)lists[3][j] + " ";
                }

                for (int j = 0; j < lists[4].Count; ++j)
                {
                    four.Text += (char)lists[4][j] + " ";
                }

                for (int j = 0; j < lists[5].Count; ++j)
                {
                    five.Text += (char)lists[5][j] + " ";
                }

                for (int j = 0; j < lists[6].Count; ++j)
                {
                    six.Text += (char)lists[6][j] + " ";
                }

                for (int j = 0; j < lists[7].Count; ++j)
                {
                    seven.Text += (char)lists[7][j] + " ";
                }

                for (int j = 0; j < lists[8].Count; ++j)
                {
                    eight.Text += (char)lists[8][j] + " ";
                }

                for (int j = 0; j < lists[9].Count; ++j)
                {
                    nine.Text += (char)lists[9][j] + " ";
                }

                //сборка массива поразрядно
                int k = 0;
                currArr.Clear();
                for (int i = 0; i < range; ++i)
                {
                    for (int j = 0; j < lists[i].Count; ++j)
                    {
                        arr[k] = (char)lists[i][j];
                        currArr.Text += arr[k] + " ";
                        ++k;
                    }
                }

                MessageBox.Show("For " + (digNum + 1) + " code digit:");

                for (int i = 0; i < range; ++i)
                    lists[i].Clear();   //очистка списков элементов по разрядам
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            sortArr.Clear();
            sorting(arr, 10, 2, zero, one, two, three, four, five, six, seven, eight, nine, currArr);
            for (int i = 0; i < size; ++i)
            {
                sortArr.Text += arr[i] + "  ";
            }
        }
    }
}
