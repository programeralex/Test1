using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {
        List<Person> personList;
        public Form1()
        {
            InitializeComponent();
             personList = new List<Person>
            {
                new Person
                {
                    Name = "P1", Age = 18, Gender = "Male",
                    Dogs = new Dog[]
                    {
                        new Dog { Name = "D1" },
                        new Dog { Name = "D2" }
                    }
                },
                new Person
                {
                    Name = "P2", Age = 19, Gender = "Male",
                    Dogs = new Dog[]
                    {
                        new Dog { Name = "D3" }
                    }
                },
                new Person
                {
                    Name = "P3", Age = 17,Gender = "Female",
                    Dogs = new Dog[]
                    {
                        new Dog { Name = "D4" },
                        new Dog { Name = "D5" },
                        new Dog { Name = "D6" }
                    }
                }
            };

        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = personList.SelectMany(p => p.Dogs, (p, d) => new { PersonName = p.Name, DogName = d.Name }).ToList();
        }
    }
    class Person
    {
        public string Name { set; get; }
        public int Age { set; get; }
        public string Gender { set; get; }
        public Dog[] Dogs { set; get; }
    }
    public class Dog
    {
        public string Name { set; get; }
    }
}
