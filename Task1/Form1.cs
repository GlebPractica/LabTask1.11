using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        private ActionWithArray<int> _workArrayInt;
        private ActionWithArray<float> _workArrayFloat;
        private ActionWithArray<double> _workArrayDouble;

        public Form1()
        {
            InitializeComponent();

            openFileDialog1.Filter = "CSV Files(*.csv)|*.csv|All files(*.*)|*.*";
        }

        private void FillRichTextBox<T>(RichTextBox richTextBox, T[] values)
        {
            richTextBox.Text = $"Массив: {string.Join("; ", values)}";
        }

        private int GetIntFromTextBox(TextBox textBox)
        {
            if (textBox is null)
                MessageBox.Show("Неожиданная ошибка. повторите попытку.");

            if (int.TryParse(textBox.Text, out int outInt))
            {
                MessageBox.Show($"Число успешно записано.\nТекущий результат: {outInt}", "Результат");
                return outInt;
            }    
            else
            {
                MessageBox.Show($"Неверно введено число. Повторите попытку.\nТекущий результат: {textBox.Text}", "Ошибка");
                return -1;
            }
        }

        private async Task<ActionWithArray<T>> WorkWithArr<T>(ActionWithArray<T> actionWithArray, string filePath = "", int batchSize = 0, bool readFromFile = false, int lenght = 0)
        {
            if (actionWithArray is null)
                actionWithArray = new ActionWithArray<T>();

            if (readFromFile)
            {
                if (actionWithArray.FilePath != filePath)
                    await Task.Run(() => actionWithArray.FillFromFileCSVAsync(filePath, batchSize));
                return actionWithArray;
            }
            else
            {
                await Task.Run(() => actionWithArray.FilledArrayNumbersFibAsync(lenght));
                return actionWithArray;
            }
        }

        private async Task<int> GetCountNumbers<T>(ActionWithArray<T> actionWithArray)
        {
            if (actionWithArray is null || actionWithArray.Array == null || actionWithArray.Array.Length < 1)
                throw new Exception("Невозможно посчитать.");

            return actionWithArray.CountBetween10And100;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = false;

                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;

                int batchSize = 1000; // Размер пакета чтения

                if (radBttnInt.Checked)
                {
                    _workArrayInt = await WorkWithArr<int>(_workArrayInt, openFileDialog1.FileName, batchSize, true);
                    MessageBox.Show($"Файл успешно открыт и прочитан. Количество прочитанных записей: {_workArrayInt.LengthArray}", "Результат");

                    FillRichTextBox(richTextBox1, _workArrayInt.Array);
                }
                else if (radioButton1.Checked)
                {
                    _workArrayFloat = await WorkWithArr<float>(_workArrayFloat, openFileDialog1.FileName, batchSize, true);
                    MessageBox.Show($"Файл успешно открыт и прочитан. Количество прочитанных записей: {_workArrayFloat.LengthArray}", "Результат");

                    FillRichTextBox(richTextBox1, _workArrayFloat.Array);
                }
                else if (radioButton2.Checked)
                {
                    _workArrayDouble = await WorkWithArr<double>(_workArrayDouble, openFileDialog1.FileName, batchSize, true);
                    MessageBox.Show($"Файл успешно открыт и прочитан. Количество прочитанных записей: {_workArrayDouble.LengthArray}", "Результат");

                    FillRichTextBox(richTextBox1, _workArrayDouble.Array);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
            finally
            {
                button1.Enabled = true;
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            int lenght = GetIntFromTextBox(textBox1);

            try
            {
                if (radBttnInt.Checked)
                {
                    _workArrayInt = await WorkWithArr(_workArrayInt, "", 0, false, lenght);
                    FillRichTextBox(richTextBox1, _workArrayInt.Array);
                }
                else if (radioButton1.Checked)
                {
                    _workArrayFloat = await WorkWithArr(_workArrayFloat, "", 0, false, lenght);
                    FillRichTextBox(richTextBox1, _workArrayFloat.Array);
                }
                else if (radioButton2.Checked)
                {
                    _workArrayDouble = await WorkWithArr(_workArrayDouble, "", 0, false, lenght);
                    FillRichTextBox(richTextBox1, _workArrayDouble.Array);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private async void BttnCount_Click(object sender, EventArgs e)
        {
            int count = 0;

            try
            {
                if (radBttnInt.Checked)
                {
                    count = await GetCountNumbers(_workArrayInt);
                    MessageBox.Show($"Количество элементов от 10 до 100 = {count}", "Результат");
                }
                else if (radioButton1.Checked)
                {
                    count = await GetCountNumbers(_workArrayFloat);
                    MessageBox.Show($"Количество элементов от 10 до 100 = {count}", "Результат");
                }
                else if (radioButton2.Checked)
                {
                    count = await GetCountNumbers(_workArrayDouble);
                    MessageBox.Show($"Количество элементов от 10 до 100 = {count}", "Результат");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
