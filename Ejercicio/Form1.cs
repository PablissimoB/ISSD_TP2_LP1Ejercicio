using System.Reflection.Emit;
using static Ejercicio.Form1;

namespace Ejercicio
{
    public partial class Form1 : Form
    {
        public NotaEstudiante[] notaEstudiantes= new NotaEstudiante[10]; 
        public class NotaEstudiante
        {
            public string nombre;
            public DateTime fechaExamen;
            public string carrera;
            public string materia;
            public int calificacion;

            public NotaEstudiante(string nombre, DateTime fechaExamen, string carrera, string materia, int calificacion)
            {
                this.nombre = nombre;
                this.fechaExamen = fechaExamen;
                this.carrera = carrera;
                this.materia = materia;
                this.calificacion = calificacion;
            }
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            string carrera ="";
            if(radioButton1.Checked)
            {
                carrera = radioButton1.Text;
            }
            else if(radioButton2.Checked)
            {
                carrera=radioButton2.Text;
            }
            int posicionVacia = Array.IndexOf(notaEstudiantes, null);

            NotaEstudiante estudianteNota = new NotaEstudiante(
                    textBox2.Text, 
                    dateTimePicker1.Value,  
                    carrera,
                    listBox1.SelectedItem.ToString(),
                    int.Parse(textBox3.Text)
                    );
            if(posicionVacia >= 0)
            {
                notaEstudiantes[posicionVacia] = estudianteNota;
            }
            else
            {
                MessageBox.Show("No se puede agregar mas notas");
            }
            for (int i = 0; i < posicionVacia+1 ; i++) 
            {
                
                    label1.Text += notaEstudiantes[i].nombre + " - ";
                    label1.Text += notaEstudiantes[i].carrera + " - ";
                    label1.Text += notaEstudiantes[i].fechaExamen.ToString() + " - ";
                    label1.Text += notaEstudiantes[i].materia + " - ";
                    label1.Text += notaEstudiantes[i].calificacion + "\n";
                
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //string[] materiasAnalista = new string[] { "TP2", "ALG3", "MATS" };
            //foreach(string mat in  materiasAnalista)
            //{
            //    listBox1.Items.Add(mat);
            //}
            if (radioButton1.Checked)
            {
                listBox1.Items.Add("TP2");
                listBox1.Items.Add("ALG3");
                listBox1.Items.Add("MAT2");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (radioButton2.Checked)
            {
                listBox1.Items.Add("LP1");
                listBox1.Items.Add("EST1");
                listBox1.Items.Add("MAT2");
            }
        }
    }
}