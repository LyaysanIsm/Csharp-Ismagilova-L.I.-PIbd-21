using ForgeShopBusinessLogic.BindingModels;
using ForgeShopBusinessLogic.BusinessLogics;
using ForgeShopBusinessLogic.Interfaces;
using ForgeShopBusinessLogic.ViewModels;
using System;
using System.Windows.Forms;
using Unity;

namespace ForgeShopView
{
    public partial class FormCreateOrder : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IForgeProductLogic logicF;
        private readonly MainLogic logicM;
        private readonly IClientLogic logicC;
        public FormCreateOrder(IForgeProductLogic logicF, IClientLogic logicC, MainLogic logicM)
        {
            InitializeComponent();
            this.logicF = logicF;
            this.logicM = logicM;
            this.logicC = logicC;
        }
        private void FormCreateOrder_Load(object sender, EventArgs e)
        {
            try
            {
                var list = logicF.Read(null);
                ComboBoxForgeProduct.DataSource = list;
                ComboBoxForgeProduct.DisplayMember = "ForgeProductName";
                ComboBoxForgeProduct.ValueMember = "Id";

                var listC = logicC.Read(null);
                ComboBoxClient.DisplayMember = "ClientFIO";
                ComboBoxClient.ValueMember = "Id";
                ComboBoxClient.DataSource = listC;
                ComboBoxClient.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        private void CalcSum()
        {
            if (ComboBoxForgeProduct.SelectedValue != null &&
           !string.IsNullOrEmpty(TextBoxCount.Text))
            {
                try
                {
                    int id = Convert.ToInt32(ComboBoxForgeProduct.SelectedValue);
                    ForgeProductViewModel forgeproduct = logicF.Read(new ForgeProductBindingModel
                    {
                        Id =
id
                    })?[0];
                    int count = Convert.ToInt32(TextBoxCount.Text);
                    textBoxSum.Text = (count * forgeproduct?.Price ?? 0).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
        private void TextBoxCount_TextChanged(object sender, EventArgs e)
        {
            CalcSum();
        }
        private void ComboBoxForgeProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcSum();
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxCount.Text))
            {
                MessageBox.Show("Заполните поле Количество", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ComboBoxForgeProduct.SelectedValue == null)
            {
                MessageBox.Show("Выберите изделие", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (ComboBoxClient.SelectedValue == null)
            {
                MessageBox.Show("Выберите клиента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                logicM.CreateOrder(new CreateOrderBindingModel
                {
                    ClientId = Convert.ToInt32(ComboBoxClient.SelectedValue),
                    ForgeProductId = Convert.ToInt32(ComboBoxForgeProduct.SelectedValue),
                    Count = Convert.ToInt32(TextBoxCount.Text),
                    Sum = Convert.ToDecimal(textBoxSum.Text)
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}