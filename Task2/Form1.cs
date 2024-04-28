using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        private HashSet<long> hashSet;
        private LinkedList<long> linkedList;

        public Form1()
        {
            InitializeComponent();
            hashSet = new HashSet<long>();
            linkedList = new LinkedList<long>();
        }

        private void FillHashSet(int count)
        {
            if (hashSet.Count > 0)
                hashSet.Clear();

            if (count < 1)
            {
                MessageBox.Show("Неверно задан размер", "Ошибка");
                return;
            }

            Random rnd = new Random();

            for (int i = 0; i <= count; i++)
            {
                hashSet.Add(rnd.Next(-50, 51));
            }
        }

        private void FillRichHash()
        {
            richTextBox1.Clear();

            int index = 1;

            foreach (long item in hashSet)
            {
                richTextBox1.AppendText($"{index} эл.: {item}\n");
                index++;
            }
        }

        private void UpdateRichLinked()
        {
            richTextBox2.Clear();

            int index = 1;

            foreach (long item in linkedList)
            {
                richTextBox2.AppendText($"{index} эл.: {item}\n");
                index++;
            }
        }

        private void BttnFillHastSet_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int count))
            {
                FillHashSet(count);
                FillRichHash();
            }
            else
            {
                MessageBox.Show($"Не удалось считать число.\nТекущий результат: {textBox1.Text}", "Ошибка");
            }
        }

        private void BttnDeleteElement_Click(object sender, EventArgs e)
        {
            if (long.TryParse(textBox2.Text, out long number))
            {
                RemoveElem(number);
            }
            else
            {
                MessageBox.Show("Неверно введено число.", "Ошибка");
            }
        }

        private void RemoveElem(long el)
        {
            if (hashSet.Contains(el))
            {
                hashSet.Remove(el);
            }
            else
            {
                MessageBox.Show("Элемент не содержится в hashSet.", "Ошибка");
            }
        }

        private void BttnFillLinkedList_Click(object sender, EventArgs e)
        {
            FillLinkedFromHash(hashSet, ref linkedList);
            UpdateRichLinked();
        }

        

        private void FillLinkedFromHash(HashSet<long> hashSet, ref LinkedList<long> linkedList)
        {
            if (hashSet.Count > 0)
            {
                foreach (long item in hashSet)
                {
                    linkedList.AddLast(item);
                }
            }
        }

        private void BttnFind_Click(object sender, EventArgs e)
        {
            
            if (long.TryParse(textBox3.Text, out long findEl))
            {
                FindElementInLinkedList(findEl);
            }
            else
            {
                MessageBox.Show("Неверно введен элемент", "Ошибка");
            }
        }

        private void FindElementInLinkedList(long v)
        {
            if (linkedList.Contains(v))
            {
                MessageBox.Show($"Элемент {v} найден", "Результат");
            }
            else
            {
                MessageBox.Show("Элемент не найден", "Ошибка");
            }
        }

        private void BttnUpdateAll_Click(object sender, EventArgs e)
        {
            FillRichHash();
            UpdateRichLinked();
        }
    }
}
