using lista16.UserControls;

namespace lista16
{
    public partial class Form1 : Form
    {

        bool mouseDown;
        Point lastLocation;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adicionarUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            content.Controls.Clear();
            content.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UC_Home ucHome = new UC_Home();
            adicionarUserControl(ucHome);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;


        }



        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;

        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (mouseDown)
            {

                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y
                );

            }

        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {


           


        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void MIcadastarSeto_Click(object sender, EventArgs e)
        {

            UC_CadastrarSetor cadSetor = new UC_CadastrarSetor();
            adicionarUserControl(cadSetor);

        }
    }
}
