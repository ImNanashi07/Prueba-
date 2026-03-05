namespace PruebaWinForms
{
    public partial class Form1 : Form
    {
        public int count {  get; set; }
        public Form1()
        {
            InitializeComponent();
            count = 0;
            inicializarBoton();
        }

        private void inicializarBoton()
        {
            Button btnMostrarEtiqueta = new Button();
            btnMostrarEtiqueta.Text = "Mostrar";
            btnMostrarEtiqueta.Size = new Size(75, 75);
            btnMostrarEtiqueta.Location = new Point(100, 200);
            btnMostrarEtiqueta.Click += mostrar_etiqueta;
            btnMostrarEtiqueta.Click += btnContar_Click;
            this.Controls.Add(btnMostrarEtiqueta);
        }

        //Eventos: "object sender, EventArgs e"
        private void mostrar_etiqueta(object sender, EventArgs e)
        {
            Label lblEtiqueta = new Label();
            lblEtiqueta.ForeColor = Color.BlueViolet;
            lblEtiqueta.Text = "Soy una etiqueta";
            lblEtiqueta.Size = new Size(50, 150);
            lblEtiqueta.Location = new Point(400, 250);
            this.Controls.Add(lblEtiqueta);
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            count++;
            btnContar.Text = count.ToString();
        }
    }
}
