using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr17
{
    public partial class Form1 : Form
    {
        private Array array1;
        private Array array2;

        public Form1()
        {
            InitializeComponent();
            array1 = new Andarray();
            array2 = new Onarray();
        }

        // Абстрактний базовий клас для масивів
        public abstract class Array
        {
            public abstract void Add(double value);
            public abstract void ForEach(Action<double> action);
        }

        // Похідний клас для Andarray
        public class Andarray : Array
        {
            private List<double> elements;

            public Andarray()
            {
                elements = new List<double>();
            }

            public override void Add(double value)
            {
                elements.Add(value);
            }

            public override void ForEach(Action<double> action)
            {
                foreach (var element in elements)
                {
                    action(Math.Sqrt(element));
                }
            }
        }

        // Похідний клас для Оnаrrау
        public class Onarray : Array
        {
            private List<double> elements;

            public Onarray()
            {
                elements = new List<double>();
            }

            public override void Add(double value)
            {
                elements.Add(value);
            }

            public override void ForEach(Action<double> action)
            {
                foreach (var element in elements)
                {
                    action(element); 
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder result1Builder = new StringBuilder();
            StringBuilder result2Builder = new StringBuilder();

            // Очищення текстових полів перед додаванням нових результатів
            result1TextBox.Clear();
            result2TextBox.Clear();

            array1.ForEach(x => result1Builder.AppendLine($"{x:F2}\t"));
            result1TextBox.Text = result1Builder.ToString();

            array2.ForEach(x => result2Builder.AppendLine($"{Math.Log(x):F2}\t"));
            result2TextBox.Text = result2Builder.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double value1 = Double.Parse(array1TextBox.Text);
            double value2 = Double.Parse(array2TextBox.Text);
            array1.Add(value1);
            array2.Add(value2);
        }
    }
}