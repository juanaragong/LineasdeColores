namespace Lineas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen plumaVerde = new Pen(Color.Green,7);
            Graphics lienzo = CreateGraphics();

            lienzo.DrawLine(plumaVerde,0,450,100,450);
            lienzo.DrawLine(plumaVerde, 100, 450, 100, 200);
            lienzo.DrawLine(plumaVerde, 100, 200, 300, 200);
            lienzo.DrawLine(plumaVerde, 300, 200, 300, 0);


            Pen plumaRoja = new Pen(Color.Red, 7);
            lienzo.DrawLine(plumaRoja,20,0,20,100);
            lienzo.DrawLine(plumaRoja, 20, 100, 350, 100);
            lienzo.DrawLine(plumaRoja, 350, 100, 350, 550);

            Pen plumaAzul=new Pen(Color.Blue, 7);
            lienzo.DrawLine(plumaAzul,200,600,200,350);
            lienzo.DrawLine(plumaAzul,200,350,30,350);
            lienzo.DrawLine(plumaAzul, 30, 350, 30, 150);
            lienzo.DrawLine(plumaAzul, 30, 150, 200, 150);
            lienzo.DrawLine(plumaAzul, 200, 150, 200, 40);
            lienzo.DrawLine(plumaAzul,200,40,400,40);

            
            

        }
    }
}