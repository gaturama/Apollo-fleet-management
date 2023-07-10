namespace Views
{
    public class CreateModel : Form
    {
        public Label lblTitle;
        public Label lblName;
        public Label lblBrandId;
        public TextBox txtName;
        public ComboBox txtBrandId;
        public Button btCrt;
        public Button btClose;
        public TableLayoutPanel panel;


        public static List<Models.Brand> GetBrandsToComboBox(){
            List<Models.Brand> brands = new List<Models.Brand>();
            foreach(Models.Brand brand in Models.Brand.ReadAllBrands()){
                if((brand.BrandId != 0) && (brand.Name != null)){
                    brands.Add(brand);
                }
            }

            return brands;
        } 


        public void btCrt_Click(object sender, EventArgs e)
        {
            Controllers.Model.CreateModel(
                txtName.Text,
                Convert.ToInt32(txtBrandId.Text)
            );

            MessageBox.Show("Modelo criado com sucesso.");
            
            ListModel ModelList = Application.OpenForms.OfType<ListModel>().FirstOrDefault();
            if(ModelList == null)
            {
                ModelList.RefreshList();
            }
            this.Close();
        }

        public CreateModel()
        {
            this.Text = "Cadastro";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.BackColor = ColorTranslator.FromHtml("#f8f8f8");
            this.Size = new System.Drawing.Size(300, 320);

            this.lblTitle = new Label();
            this.lblTitle.Text = "Cadastro de Modelo";
            this.lblTitle.Font = new Font("Segoe UI", 13f, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new Point(60, 30);
            this.lblTitle.Size = new Size(250, 40);

            this.lblName = new Label();
            this.lblName.Text = "Nome:";
            this.lblName.Location = new Point(33, lblTitle.Bottom + 10);
            this.lblName.Size = new Size(70, 40);

            this.txtName = new TextBox();
            this.txtName.Location = new Point(33, lblName.Bottom + 5);
            this.txtName.BorderStyle = BorderStyle.FixedSingle;
            this.txtName.BackColor = ColorTranslator.FromHtml("#E0E6ED");
            this.txtName.Size = new Size(220, 50);

            this.lblBrandId = new Label();
            this.lblBrandId.Text = "Marca:";
            this.lblBrandId.Location = new Point(33, txtName.Bottom + 10);
            this.lblBrandId.Size = new Size(70, 20);

            this.txtBrandId = new ComboBox();
            this.txtBrandId.Location = new Point(33, lblBrandId.Bottom + 5);
            this.txtBrandId.Size = new Size(220, 20);
            this.txtBrandId.DropDownStyle = ComboBoxStyle.DropDownList;
            this.txtBrandId.BackColor = ColorTranslator.FromHtml("#E0E6ED");
            this.txtBrandId.FlatStyle = FlatStyle.Flat;

            this.txtBrandId.DataSource = GetBrandsToComboBox();
            this.txtBrandId.DisplayMember = "Name";
            this.txtBrandId.ValueMember = "ModelId";


            
            this.panel = new TableLayoutPanel();
            this.panel.Dock = DockStyle.Bottom;
            this.panel.AutoSize = true;
            this.panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.panel.Padding = new Padding(10, 10, 10, 10);
            this.panel.BackColor = ColorTranslator.FromHtml("#BFCBE9");
            this.panel.ColumnCount = 4;
            this.panel.RowCount = 1;
            this.panel.ColumnStyles.Clear();

            for (int i = 0; i < 4; i++)
            {
                this.panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            }

            this.btCrt = new Button();
            this.btCrt.Text = "Adicionar";
            //this.btCrt.Location = new Point(80, panel.Bottom + 10);
            this.btCrt.Font = new Font("Arial", 8, FontStyle.Regular);
            this.btCrt.FlatStyle = FlatStyle.Flat;
            this.btCrt.FlatAppearance.BorderSize = 0;
            this.btCrt.BackColor = ColorTranslator.FromHtml("#E0E6ED");
            this.btCrt.ForeColor = ColorTranslator.FromHtml("#000000");
            this.btCrt.Dock = DockStyle.Fill;
            this.btCrt.Click += new EventHandler(btCrt_Click);

            this.btClose = new Button();
            this.btClose.Text = "Fechar";
            //this.btClose.Location = new Point(80, btCrt.Bottom + 10);
            this.btClose.Font = new Font("Arial", 8, FontStyle.Regular);
            this.btClose.FlatStyle = FlatStyle.Flat;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.BackColor = ColorTranslator.FromHtml("#E0E6ED");
            this.btClose.ForeColor = ColorTranslator.FromHtml("#000000");
            this.btClose.Dock = DockStyle.Fill;
            this.btClose.Click += (sender, s) =>
            {
                this.Close();
            };
            
            this.panel.Controls.Add(btCrt, 1, 0);
            this.panel.Controls.Add(btClose, 2, 0);

            this.Controls.Add(panel);
            this.Controls.Add(lblTitle);
            this.Controls.Add(lblName);
            this.Controls.Add(txtName);
            this.Controls.Add(lblBrandId);
            this.Controls.Add(txtBrandId);
        }
    }
}