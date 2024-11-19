using OfficeEquipment;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace OfficeEquipment_
{
    public partial class Form1 : Form
    {
        private List<OfficeEquip> devices = new List<OfficeEquip>();

        public Form1()
        {
            InitializeComponent();
        }

        private int GetValidInt(string input, int min, int max)
        {
            if (int.TryParse(input, out int value) && value >= min && value <= max)
            {
                return value;
            }
            else
            {
                MessageBox.Show("Неверный ввод. Попробуйте еще раз.");
                return 0; // Возвращаем 0 или любое другое значение по умолчанию
            }
        }

        private void btnAddEquipment_Click_1(object sender, EventArgs e)
        {
            Form inputForm = new Form();
            inputForm.Text = "Ввод данных";
            inputForm.Size = new System.Drawing.Size(300, 200);

            Label lblModel = new Label();
            lblModel.Text = "Введите модель:";
            lblModel.Location = new System.Drawing.Point(10, 10);
            inputForm.Controls.Add(lblModel);

            TextBox txtModel = new TextBox();
            txtModel.Location = new System.Drawing.Point(10, 30);
            inputForm.Controls.Add(txtModel);

            Label lblPrice = new Label();
            lblPrice.Text = "Введите цену:";
            lblPrice.Location = new System.Drawing.Point(10, 60);
            inputForm.Controls.Add(lblPrice);

            TextBox txtPrice = new TextBox();
            txtPrice.Location = new System.Drawing.Point(10, 80);
            inputForm.Controls.Add(txtPrice);

            Label lblScanSpeed = new Label();
            lblScanSpeed.Text = "Введите скорость сканирования:";
            lblScanSpeed.Location = new System.Drawing.Point(10, 110);
            inputForm.Controls.Add(lblScanSpeed);

            TextBox txtScanSpeed = new TextBox();
            txtScanSpeed.Location = new System.Drawing.Point(10, 130);
            inputForm.Controls.Add(txtScanSpeed);

            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.Location = new System.Drawing.Point(100, 160);
            btnOK.DialogResult = DialogResult.OK;
            inputForm.AcceptButton = btnOK;
            inputForm.Controls.Add(btnOK);

            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                var officeEquip = new OfficeEquip
                {
                    Model = txtModel.Text,
                    Price = GetValidInt(txtPrice.Text, 1, 100000),
                    ScanSpeed = GetValidInt(txtScanSpeed.Text, 1, 200)
                };
                devices.Add(officeEquip);
                MessageBox.Show("Офисное оборудование добавлено.");
            }
        }

        private void btnAddPrinter_Click_1(object sender, EventArgs e)
        {
            Form inputForm = new Form();
            inputForm.Text = "Ввод данных";
            inputForm.Size = new System.Drawing.Size(300, 250);

            Label lblModel = new Label();
            lblModel.Text = "Введите модель:";
            lblModel.Location = new System.Drawing.Point(10, 10);
            inputForm.Controls.Add(lblModel);

            TextBox txtModel = new TextBox();
            txtModel.Location = new System.Drawing.Point(10, 30);
            inputForm.Controls.Add(txtModel);

            Label lblStorage = new Label();
            lblStorage.Text = "Введите ёмкость картриджа:";
            lblStorage.Location = new System.Drawing.Point(10, 60);
            inputForm.Controls.Add(lblStorage);

            TextBox txtStorage = new TextBox();
            txtStorage.Location = new System.Drawing.Point(10, 80);
            inputForm.Controls.Add(txtStorage);

            Label lblPrice = new Label();
            lblPrice.Text = "Введите цену:";
            lblPrice.Location = new System.Drawing.Point(10, 110);
            inputForm.Controls.Add(lblPrice);

            TextBox txtPrice = new TextBox();
            txtPrice.Location = new System.Drawing.Point(10, 130);
            inputForm.Controls.Add(txtPrice);

            Label lblScanSpeed = new Label();
            lblScanSpeed.Text = "Введите скорость сканирования:";
            lblScanSpeed.Location = new System.Drawing.Point(10, 160);
            inputForm.Controls.Add(lblScanSpeed);

            TextBox txtScanSpeed = new TextBox();
            txtScanSpeed.Location = new System.Drawing.Point(10, 180);
            inputForm.Controls.Add(txtScanSpeed);

            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.Location = new System.Drawing.Point(100, 210);
            btnOK.DialogResult = DialogResult.OK;
            inputForm.AcceptButton = btnOK;
            inputForm.Controls.Add(btnOK);

            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                var printer = new Printer
                {
                    Model = txtModel.Text,
                    Storage = GetValidInt(txtStorage.Text, 500, 15000),
                    Price = GetValidInt(txtPrice.Text, 1, 100000),
                    ScanSpeed = GetValidInt(txtScanSpeed.Text, 1, 200)
                };
                devices.Add(printer);
                MessageBox.Show("Принтер добавлен.");
            }
        }

        private void btnAddFax_Click_1(object sender, EventArgs e)
        {
            Form inputForm = new Form();
            inputForm.Text = "Ввод данных";
            inputForm.Size = new System.Drawing.Size(300, 250);

            Label lblModel = new Label();
            lblModel.Text = "Введите модель:";
            lblModel.Location = new System.Drawing.Point(10, 10);
            inputForm.Controls.Add(lblModel);

            TextBox txtModel = new TextBox();
            txtModel.Location = new System.Drawing.Point(10, 30);
            inputForm.Controls.Add(txtModel);

            Label lblPhoneLines = new Label();
            lblPhoneLines.Text = "Кол-во линий:";
            lblPhoneLines.Location = new System.Drawing.Point(10, 60);
            inputForm.Controls.Add(lblPhoneLines);

            TextBox txtPhoneLines = new TextBox();
            txtPhoneLines.Location = new System.Drawing.Point(10, 80);
            inputForm.Controls.Add(txtPhoneLines);

            Label lblPrice = new Label();
            lblPrice.Text = "Введите цену:";
            lblPrice.Location = new System.Drawing.Point(10, 110);
            inputForm.Controls.Add(lblPrice);

            TextBox txtPrice = new TextBox();
            txtPrice.Location = new System.Drawing.Point(10, 130);
            inputForm.Controls.Add(txtPrice);

            Label lblScanSpeed = new Label();
            lblScanSpeed.Text = "Введите скорость сканирования:";
            lblScanSpeed.Location = new System.Drawing.Point(10, 160);
            inputForm.Controls.Add(lblScanSpeed);

            TextBox txtScanSpeed = new TextBox();
            txtScanSpeed.Location = new System.Drawing.Point(10, 180);
            inputForm.Controls.Add(txtScanSpeed);

            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.Location = new System.Drawing.Point(100, 210);
            btnOK.DialogResult = DialogResult.OK;
            inputForm.AcceptButton = btnOK;
            inputForm.Controls.Add(btnOK);

            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                var fax = new Fax
                {
                    Model = txtModel.Text,
                    PhoneLines = GetValidInt(txtPhoneLines.Text, 1, 50),
                    Price = GetValidInt(txtPrice.Text, 1, 100000),
                    ScanSpeed = GetValidInt(txtScanSpeed.Text, 1, 200)
                };
                devices.Add(fax);
                MessageBox.Show("Факс добавлен.");
            }
        }

        private void btnShowDevices_Click_1(object sender, EventArgs e)
        {
            txtOutput.Clear();
            if (devices.Count > 0)
            {
                foreach (var device in devices)
                {
                    txtOutput.AppendText(device.ToString() + Environment.NewLine);
                }
            }
            else
            {
                txtOutput.AppendText("Устройства не найдены.");
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
