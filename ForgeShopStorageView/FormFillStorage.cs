using ForgeShopBusinessLogic.BindingModels;
using ForgeShopBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ForgeShopStorageView
{
    public partial class FormFillStorage : Form
    {
        private int id;
        public FormFillStorage(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void FormFillStorage_Load(object sender, System.EventArgs e)
        {
            try
            {
                List<BilletViewModel> list = APIStorage.GetRequest<List<BilletViewModel>>($"api/storage/getbilletslist");
                if (list != null)
                {
                    comboBoxBillet.DisplayMember = "BilletName";
                    comboBoxBillet.ValueMember = "Id";
                    comboBoxBillet.DataSource = list;
                    comboBoxBillet.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSave_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCount.Text))
            {
                MessageBox.Show("Заполните поле Количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxBillet.SelectedValue == null)
            {
                MessageBox.Show("Выберите компонент", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                APIStorage.PostRequest("api/storage/fillstorage", new StorageBilletBindingModel
                {
                    Id = 0,
                    StorageId = id,
                    BilletId = Convert.ToInt32(comboBoxBillet.SelectedValue),
                    Count = Convert.ToInt32(textBoxCount.Text)
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}