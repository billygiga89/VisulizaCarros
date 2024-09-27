namespace VisulizaCarros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtém uma lista de arquivos na pasta especificada
            string[] nomeCarros = Directory.GetFiles(@"C:pasta com as fotos");

            // Percorre cada arquivo encontrado na pasta
            foreach (string img in nomeCarros)
            {
                // Separa o caminho do arquivo usando o caractere '\'
                string[] separador = img.Split('\\');

                // Pega o nome do arquivo e separa pelo ponto (.)
                string[] selecionado = separador[6].Split('.');

                // Verifica se o texto do ComboBox corresponde ao nome do arquivo (sem extensão)
                if (comboBox2.Text == selecionado[0])
                {
                    // Define a localização da imagem do PictureBox para o caminho do arquivo correspondente
                    pictureBox1.ImageLocation = @"C:pasta com as fotos" + comboBox2.Text + ".jpg";

                    // Ajusta o modo de exibição da imagem para esticar para preencher o PictureBox
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = string.Empty;

            if (comboBox1.Text == "FIAT")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("UNO");
                comboBox2.Items.Add("PALIO");
            }
            else if (comboBox1.Text == "FORD")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("ECOSPORT");
                comboBox2.Items.Add("KA");
            }
            else if (comboBox1.Text == "CHEVROLET")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("CELTA");
                comboBox2.Items.Add("AGILE");
            }
            else if (comboBox1.Text == "VOLKSWAGEN")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("GOL");
                comboBox2.Items.Add("POLO");
            }
            else if (comboBox1.Text == "HYUNDAI")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("ELANTRA");
                comboBox2.Items.Add("HB20");
            }
            else if (comboBox1.Text == "JEEP")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("RENEGADE");
                comboBox2.Items.Add("CHEROKEE");
            }
            else if (comboBox1.Text == "FERRARI")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("SF90");
                comboBox2.Items.Add("SPIDER F8");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
