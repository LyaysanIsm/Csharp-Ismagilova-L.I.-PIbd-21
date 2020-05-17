using ForgeShopBusinessLogic.BindingModels;
using ForgeShopBusinessLogic.BusinessLogics;
using ForgeShopBusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace ForgeShopView
{
    public partial class FormFillStorage : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IBilletLogic logicB;
        private readonly MainLogic logicM;
        private readonly IStorageLogic logicS;
        public FormFillStorage(IBilletLogic logicB, MainLogic logicM, IStorageLogic logicS)
        {
            InitializeComponent();
            this.logicB = logicB;
            this.logicM = logicM;
            this.logicS = logicS;
        }

        private void FormFillStorage_Load(object sender, EventArgs e)
        {
            try
            {
                var storageList = logicS.GetList();
                comboBoxstorage.DataSource = storageList;
                comboBoxstorage.DisplayMember = "StorageName";
                comboBoxstorage.ValueMember = "Id";
                var BilletList = logicB.Read(null);
                comboBoxbillet.DataSource = BilletList;
                comboBoxbillet.DisplayMember = "BilletName";
                comboBoxbillet.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxcount.Text))
            {
                MessageBox.Show("Заполните количество", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (comboBoxstorage.SelectedValue == null)
            {
                MessageBox.Show("Выберите склад", "Ошибка", MessageBoxButtons.OK,
MessageBoxIcon.Error);
                return;
            }
            if (comboBoxbillet.SelectedValue == null)
            {
                MessageBox.Show("Выберите компонент", "Ошибка", MessageBoxButtons.OK,
MessageBoxIcon.Error);
                return;
            }
            try
            {
                int storageId = Convert.ToInt32(comboBoxstorage.SelectedValue);
                int billetId = Convert.ToInt32(comboBoxbillet.SelectedValue);
                int count = Convert.ToInt32(textBoxcount.Text);
                this.logicM.FillStorage(new StorageBilletBindingModel
                {
                    StorageId = storageId,
                    BilletId = billetId,
                    Count = count
                });
                MessageBox.Show("Склад успешно пополнен", "Сообщение",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
MessageBoxIcon.Error);
            }
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}