namespace Ex_Manipulação_de_Texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            string [] palavras = texto.Split(' ',',','.');
            int totalpalavras = palavras.Length;
            
            textBox2.Text = totalpalavras.ToString();
        }

        private void btncontarletras_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            string numeroletras = string.Empty;
            int count = 0;

            foreach(char x in texto)
            {
                count++;
                numeroletras = count.ToString();
            }
            textBox2.Text = numeroletras;
        }

        private void btnmaiuscula_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            string maiusculo = texto.ToUpper();
            textBox2.Text= maiusculo;
        }

        private void btnminuscula_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            string minusculo = texto.ToLower();
            textBox2.Text = minusculo;
        }

        private void btninverterpalavras_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            string[] palavras = texto.Split(' ', ',', '.');
            string invertido = string.Empty;

            for(int i = palavras.Length - 1; i >= 0; i--)
            {
                invertido += palavras[i] + " ";
            }
            textBox2.Text = invertido;

        }

       
       

        private void btninverterletras_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            char[] letras = texto.ToCharArray();
            string invertido = string.Empty;
            for (int i = letras.Length - 1; i >= 0; i--)
            {
                invertido += texto[i];
            }

            textBox2.Text = invertido; 

        }

        private void btnquebralinha_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            string[] palavras = texto.Split(' ', ',', '.');
            
            
           foreach(var item in palavras)
           {
               // textBox2.Text += item + Environment.NewLine;
                textBox2.Lines = palavras;

            }
        }

        private void btnembaralharpalavras_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            string texto = textBox1.Text;
            string[] palavras = texto.Split(' ', ',', '.');
            var embaralhado = palavras.OrderBy(ItemActivation => rnd.Next());
            foreach (var item in embaralhado)
            {
                textBox2.Text += item + " ";

            }
        }

        private void btnembaralharletras_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            var rnd = new Random();
            var embaralhado = texto.OrderBy(ItemActivation => rnd.Next());


            foreach (var item in embaralhado)
            {
                textBox2.Text += item;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("");
            textBox2.Text = ("");
        }
    }
}