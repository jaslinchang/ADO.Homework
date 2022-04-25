using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.Homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1number_Click(object sender, EventArgs e)
        {
            int right;
            bool isNum = int.TryParse(txt1.Text, out right);

            if (isNum)
            {
                if (right % 2 == 0)
                {
                    labAnswer.Text = ("輸入的數' " + right + " '為偶數" + "。");
                }
                else if (right % 2 != 0)
                {
                    labAnswer.Text = ("輸入的數 ' " + right + " '為奇數" + "。");
                }
            }
            else
            {
                DialogResult = MessageBox.Show("請輸入數值");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int a = r.Next(1, 100);
            int b = r.Next(1, 100);
            int c = r.Next(1, 100);
            int[] arr = new int[] { a, b, c };

            labAnswer.Text = $"三個數 : {a}、{b}、{c}，最大值為 '{arr.Max()}'，最小值為'{arr.Min()}'";

        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int stepshow = int.Parse(txtStep.Text) - 1;
            int a = int.Parse(txtFrom.Text);
            int b = int.Parse(txtTo.Text);
            int c = int.Parse(txtStep.Text);
            int sum = 0;

            for (int i = a; i < b; i += c)
            {
                sum = sum + i;
            }

            labAnswer.Text = txtFrom.Text + " 到 " + txtTo.Text + " 相隔 " + stepshow + "\n"
                + "加總為 : " + sum;
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int stepshow = int.Parse(txtStep.Text) - 1;
            int a = int.Parse(txtFrom.Text);
            int b = int.Parse(txtTo.Text);
            int c = int.Parse(txtStep.Text);
            int sum = 0;
            int i = a;
            while (i < b)
            {
                sum = sum + i;
                i += c;
            }
            labAnswer.Text = txtFrom.Text + " 到 " + txtTo.Text + " 相隔 " + stepshow + "\n"
              + "加總為 : " + sum;
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            int stepshow = int.Parse(txtStep.Text) - 1;
            int a = int.Parse(txtFrom.Text);
            int b = int.Parse(txtTo.Text);
            int c = int.Parse(txtStep.Text);
            int sum = 0;
            int i = a;

            do
            {
                sum = sum + i;
                i += c;
            } while (i < b);

            labAnswer.Text = txtFrom.Text + " 到 " + txtTo.Text + " 相隔 " + stepshow + "\n"
             + "加總為 : " + sum;
        }

        private void btn1find_Click(object sender, EventArgs e)
        {
            int[] nums = { 33, 4, 5, 11, 222, 34 };
            int odd = 0; //奇數
            int even = 0;  //偶數

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    even++;
                }
                else if (nums[i] % 2 != 0)
                {
                    odd++;
                }
            }
            labAnswer.Text = "int 陣列 nums = { 33, 4, 5, 11, 222, 34 }" + "\n奇數共" + odd + "\n偶數共" + even;
        }

        private void btn2name_Click(object sender, EventArgs e)
        {
            string[] names = { "aaa", "ksdkfjsdk" };
            string max = "";
            for (int i = 0; i < names.Length - 1; i++)
            {
                max = names[i + 1].Length > names[i].Length ? names[i + 1] : names[i];
            }
            labAnswer.Text = "arr_Str陣列 : aaa, ksdkfjsdk\n" + "最長的名字為 " + max;
        }

        private void btn2Cc_Click(object sender, EventArgs e)
        {
            string[] arr_Str = new string[] { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
            int count = 0;

            for (int i = 0; i < arr_Str.Length; i++)
            {
                if (arr_Str[i].Contains("C"))
                {
                    count++;
                }
                else if (arr_Str[i].Contains("c"))
                {
                    count++;
                }
            }

            labAnswer.Text = "arr_Str陣列 : mother張 , emma , 迪克蕭 , J40 , Candy , Cindy , Coconut , Motherfacker\n" +
                            "有C及c的名字共有 " + count + "個";
        }

        private void btn1Max_Click(object sender, EventArgs e)
        {
            //Max (params int[] )
            string max = MAX(2, 3, 46, 33, 22, 100, 150, 33, 55);

            labAnswer.Text = "int 陣列 arr[2, 3, 46, 33, 22, 100, 150, 33, 55]" + "\n最大值為 " + max;
        }
        string MAX(params int[] scores)
        {
            int mm = scores.Max();

            return mm.ToString();
        }

        private void btn1Min_Click(object sender, EventArgs e)
        {
            // MAX()   / Min ( int[] )
            int[] scores = { 2, 3, 46, 33, 22, 100, 150, 33, 55 };

            int max = scores.Max();
            int min = scores.Min();

            labAnswer.Text = "int 陣列 arr[2, 3, 46, 33, 22, 100, 150, 33, 55]" + "\n最大值為 " + max + "\n最小值為 " + min;
        }

        private void btn99_Click(object sender, EventArgs e)
        {
            string result = "";
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    if (j == 10)
                    {
                        result += "\n";
                    }
                    else result += " " + j + "  x " + i + "=" + (i * j).ToString("#00") + " | ";
                }
            }
            labAnswer.Text = "九九乘法表\n" + result;
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            int a = 100;
            int b;
            string result = "";

            while (a > 0)
            {
                b = a % 2;
                a /= 2;
                result = b + result;
            }

            labAnswer.Text = result;
        }

        private void btnLotto_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            int[] arr = new int[6];
            string result = "";

            for (int i = 0; i < 6; i++)
            {
                arr[i] = ran.Next(1, 50);

                for (int j = 0; j < i; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        j = 0;
                        arr[i] = ran.Next(1, 50);
                    }
                }
                result += arr[i] + "  ";
            }
            labAnswer.Text = "樂透號碼\n" + result;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labAnswer.Text = "結果";
        }

        private void btnTree_Click(object sender, EventArgs e)
        {
            string result = "";
            int Row = int.Parse(txtRow.Text);

            result += "* ";
            for (int i = 0; i < Row; i++)
            {
                for (int k = 1; k <= Row; k++)
                {
                    if (k == i)
                    {
                        result += "* ";
                    }
                    if (k > i)
                    {
                        result += " ";
                    }
                    else result += "* ";
                }
                result += "\n";
            }
            labAnswer.Text = result;
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            int n1 = 100, n2 = 200;
            string result = "換位前n1=" + n1 + ", n2=" + n2 + "\n";
            Swap(ref n1, ref n2);

            labAnswer.Text = result + "換位後n1=" + n1 + ", n2=" + n2;
        }

        void Swap(ref int n1, ref int n2)
        {
            int T = n1;
            n1 = n2;
            n2 = T;

        }

        private void btn1010_Click(object sender, EventArgs e)
        {
            string result = "";
            int[,] arr = new int[10, 10];

            for (int i = 0; i < arr.GetLength(0); i += 2)
            {
                for (int k = 0; k < arr.GetLength(0); k += 2)
                {
                    arr[i, k] = 1;
                }
            }
            for (int i = 1; i < arr.GetLength(0); i += 2)
            {
                for (int k = 1; k < arr.GetLength(0); k += 2)
                {
                    arr[i, k] = 1;
                }
            }

            for (int a = 0; a < arr.GetLength(0); a++)
            {
                for (int b = 0; b < arr.GetLength(1); b++)
                {
                    result += arr[a, b] + " ";
                }
                result += "\n";
            }
            labAnswer.Text = result;
        }

        private void btn1Sum_Click(object sender, EventArgs e)
        {
            int[] arr = new int[] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            labAnswer.Text = "int 陣列 arr[1 , 5 , 6 , 8 , 7 , 97 , 54 , 887 , 65 , 578]" + "\n加總為 " + sum;
        }
    }
    
}
