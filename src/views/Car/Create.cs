namespace Views
{
    public class CreateCar: Form
    {
        public Label lblTitle;
        public Label lblYear;
        public Label lblColor;
        public Label lblLicensePlate;
        public Label lblBodyworkType;
        public Label lblPrice;
        public Label lblChassisCode;
        public Label lblRenavanCode;
        public Label lblFuelType;
        public Label lblCarTransmissionType;
        public Label lblCarMileage;
        public Label lblModelId;
        public Label lblBrandId;
        public ComboBox txtYear;
        public TextBox txtColor;
        public TextBox txtLicensePlate;
        public TextBox txtBodyworkType;
        public TextBox txtPrice;
        public TextBox txtChassisCode;
        public TextBox txtRenavanCode;
        public ComboBox txtFuelType;
        public ComboBox txtCarTransmissionType;
        public TextBox txtCarMileage;
        public TextBox txtModelId;
        public TextBox txtBrandId;
        public TableLayoutPanel panel;
        public Button btClose;
        public Button btCrt;

        public void btCrt_Click(object sender, EventArgs e)
        {
           Controllers.Car.CreateCar(
                Convert.ToInt32(txtYear.Text),
                txtColor.Text,
                txtLicensePlate.Text,
                txtBodyworkType.Text,
                Convert.ToInt32(txtPrice.Text),
                txtChassisCode.Text,
                txtRenavanCode.Text,
                txtFuelType.Text,
                txtCarTransmissionType.Text,
                Convert.ToInt32(txtCarMileage),
                Convert.ToInt32(txtModelId.Text),
                Convert.ToInt32(txtBrandId.Text)
           );

            // Controllers.Document.CreateDocument(
            //     "Renavan",
            //     txtRenavanCode.Text,
            //     Convert.ToInt32(txtBrandId.Text)
            // );
            // Controllers.Model.CreateModel(
            //     cboModels.Text,


                
            // );

           MessageBox.Show("Carro criado com sucesso.");

           ListCar CarList = Application.OpenForms.OfType<ListCar>().FirstOrDefault();
           if (CarList == null)
           {
                CarList.RefreshList();
           }
            this.Close();
        }

        private void ComboBoxAno()
        {
            int anoAtual = DateTime.Now.Year;

            for (int ano = 1980; ano <= anoAtual; ano++)
            {
                txtYear.Items.Add(ano);
            }
        }

        private void Load(object sender, EventArgs e)
        {
            ComboBoxAno();
        }

        public CreateCar()
        {
            this.Text = "Cadastro";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Size = new System.Drawing.Size(590, 580);

            this.lblTitle = new Label();
            this.lblTitle.Text = "Cadastro de Carros";
            this.lblTitle.Font = new Font("Segoe UI", 15, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new Point(190, 30);
            this.lblTitle.Size = new Size(250, 40);

            this.lblYear = new Label();
            this.lblYear.Text = "Ano:";
            this.lblYear.Location = new Point(33, lblTitle.Bottom + 10);
            this.lblYear.Size = new Size(70, 20);

            this.txtYear = new ComboBox();
            this.txtYear.Location = new Point(33, lblYear.Bottom + 5);
            this.txtYear.Size = new Size(220, 20);
            ComboBoxAno();
            this.Controls.Add(txtYear);

            this.lblColor = new Label();
            this.lblColor.Text = "Cor:";
            this.lblColor.Location = new Point(320, lblTitle.Bottom + 10);
            this.lblColor.Size = new Size(70, 20);

            this.txtColor = new TextBox();
            this.txtColor.Location = new Point(320, txtYear.Bottom - 23);
            this.txtColor.BorderStyle = BorderStyle.FixedSingle;
            this.txtColor.Size = new Size(220, 20);

            this.lblLicensePlate = new Label();
            this.lblLicensePlate.Text = "Placa:";
            this.lblLicensePlate.Location = new Point(33, txtColor.Bottom + 10);
            this.lblLicensePlate.Size = new Size(110, 20);

            this.txtLicensePlate = new TextBox();
            this.txtLicensePlate.Location = new Point(33, lblLicensePlate.Bottom + 5);
            this.txtLicensePlate.BorderStyle = BorderStyle.FixedSingle;
            this.txtLicensePlate.Size = new Size(220, 20);

            this.lblBodyworkType = new Label();
            this.lblBodyworkType.Text = "Carroceria:";
            this.lblBodyworkType.Location = new Point(320, lblLicensePlate.Bottom - 20);
            this.lblBodyworkType.Size = new Size(100, 20);

            this.txtBodyworkType = new TextBox();
            this.txtBodyworkType.Location = new Point(320, txtLicensePlate.Bottom - 23);
            this.txtBodyworkType.BorderStyle = BorderStyle.FixedSingle;
            this.txtBodyworkType.Size = new Size(220, 20);

            this.lblPrice = new Label();
            this.lblPrice.Text = "Preço:";
            this.lblPrice.Location = new Point(33, txtBodyworkType.Bottom + 10);
            this.lblPrice.Size = new Size(70, 20);

            this.txtPrice = new TextBox();
            this.txtPrice.Location = new Point(33, lblPrice.Bottom + 5);
            this.txtPrice.BorderStyle = BorderStyle.FixedSingle;
            this.txtPrice.Size = new Size(220, 20);

            this.lblChassisCode = new Label();
            this.lblChassisCode.Text = "Código do Chassis:";
            this.lblChassisCode.Location = new Point(320, lblPrice.Bottom - 20);
            this.lblChassisCode.Size = new Size(120, 20);

            this.txtChassisCode = new TextBox();
            this.txtChassisCode.Location = new Point(320, txtPrice.Bottom - 23);
            this.txtChassisCode.BorderStyle = BorderStyle.FixedSingle;
            this.txtChassisCode.Size = new Size(220, 20);

            this.lblFuelType = new Label();
            this.lblFuelType.Text = "Combustível";
            this.lblFuelType.Location = new Point(33, txtChassisCode.Bottom + 10);
            this.lblFuelType.Size = new Size(120, 20);

            this.txtFuelType = new ComboBox();
            this.txtFuelType.Location = new Point(33, lblFuelType.Bottom + 5);
            this.txtFuelType.Size = new Size(220, 20);
            this.txtFuelType.Items.Add("Diesel");
            this.txtFuelType.Items.Add("Elétrico");
            this.txtFuelType.Items.Add("Etanol");
            this.txtFuelType.Items.Add("Flex");
            this.txtFuelType.Items.Add("Gasolina");
            this.txtFuelType.Items.Add("Gás");
            this.txtFuelType.Items.Add("Híbrido");

            this.lblRenavanCode = new Label();
            this.lblRenavanCode.Text = "Código do Renavan:";
            this.lblRenavanCode.Location = new Point(320, lblFuelType.Bottom - 20);
            this.lblRenavanCode.Size = new Size(120, 20);

            this.txtRenavanCode = new TextBox();
            this.txtRenavanCode.Location = new Point(320, txtFuelType.Bottom - 23);
            this.txtRenavanCode.BorderStyle = BorderStyle.FixedSingle;
            this.txtRenavanCode.Size = new Size(220, 20);

            this.lblCarTransmissionType = new Label();
            this.lblCarTransmissionType.Text = "Transmissão:";
            this.lblCarTransmissionType.Location = new Point(33, txtFuelType.Bottom + 10);
            this.lblCarTransmissionType.Size = new Size(140, 20);

            this.txtCarTransmissionType = new ComboBox();
            this.txtCarTransmissionType.Location = new Point(33, lblCarTransmissionType.Bottom + 5);
            this.txtCarTransmissionType.Size = new Size(220, 20);
            this.txtCarTransmissionType.Items.Add("Manual");
            this.txtCarTransmissionType.Items.Add("Automático");
            this.txtCarTransmissionType.Items.Add("Automatizado");
            
            this.lblCarMileage = new Label();
            this.lblCarMileage.Text = "Quilometragem:";
            this.lblCarMileage.Location = new Point(320, lblCarTransmissionType.Bottom - 20);
            this.lblCarMileage.Size = new Size(110, 20);

            this.txtCarMileage = new TextBox();
            this.txtCarMileage.Location = new Point(320, txtCarTransmissionType.Bottom - 23);
            this.txtCarMileage.BorderStyle = BorderStyle.FixedSingle;
            this.txtCarMileage.Size = new Size(220, 20);

            this.lblModelId = new Label();
            this.lblModelId.Text = "Modelo:";
            this.lblModelId.Location = new Point(33, txtCarMileage.Bottom + 10);
            this.lblModelId.Size = new Size(70, 20);

            this.txtModelId = new TextBox();
            this.txtModelId.Location = new Point(33, lblModelId.Bottom + 5);
            this.txtModelId.BorderStyle = BorderStyle.FixedSingle;
            this.txtModelId.Size = new Size(220, 20);

            this.lblBrandId = new Label();
            this.lblBrandId.Text = "Marca:";
            this.lblBrandId.Location = new Point(320, lblModelId.Bottom - 20);
            this.lblBrandId.Size = new Size(70, 20);

            this.txtBrandId = new TextBox();
            this.txtBrandId.Location = new Point(320, txtModelId.Bottom - 23);
            this.txtBrandId.BorderStyle = BorderStyle.FixedSingle;
            this.txtBrandId.Size = new Size(220, 20);

            this.panel = new TableLayoutPanel();
            this.panel.Dock = DockStyle.Bottom;
            this.panel.AutoSize = true;
            this.panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.panel.Padding = new Padding(10, 10, 10, 10);
            this.panel.BackColor = ColorTranslator.FromHtml("#58ACFA");
            this.panel.ColumnCount = 3;
            this.panel.RowCount = 1;
            this.panel.ColumnStyles.Clear();

            for (int i = 0; i < panel.ColumnCount; i++)
            {
                this.panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            }

            this.btCrt = new Button();
            this.btCrt.Text = "Adicionar";
            //this.btCrt.Location = new Point(80, panel.Bottom + 10);
            this.btCrt.Size = new Size(200, 25);
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
            this.btClose.Size = new Size(200, 25);
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
            this.Controls.Add(lblYear);
            this.Controls.Add(txtYear);
            this.Controls.Add(lblColor);
            this.Controls.Add(txtColor);
            this.Controls.Add(lblLicensePlate);
            this.Controls.Add(txtLicensePlate);
            this.Controls.Add(lblBodyworkType);
            this.Controls.Add(txtBodyworkType);
            this.Controls.Add(lblPrice);
            this.Controls.Add(txtPrice);
            this.Controls.Add(lblChassisCode);
            this.Controls.Add(txtChassisCode);
            this.Controls.Add(lblRenavanCode);
            this.Controls.Add(txtRenavanCode);
            this.Controls.Add(lblFuelType);
            this.Controls.Add(txtFuelType);
            this.Controls.Add(lblCarTransmissionType);
            this.Controls.Add(txtCarTransmissionType);
            this.Controls.Add(lblCarMileage);
            this.Controls.Add(txtCarMileage);
            this.Controls.Add(lblModelId);
            this.Controls.Add(txtModelId);
            this.Controls.Add(lblBrandId);
            this.Controls.Add(txtBrandId);
        }
    }
}