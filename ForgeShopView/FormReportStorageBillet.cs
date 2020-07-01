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
    public partial class FormReportStorageBillet : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ReportLogic logic;
        private readonly IStorageLogic storageLogic;
        public FormReportStorageBillet(ReportLogic logic, IStorageLogic storageLogic)
        {
            InitializeComponent();
            this.logic = logic;
            this.storageLogic = storageLogic;
        }

        private void ButtonSaveToExcel_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog { Filter = "xlsx|*.xlsx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        logic.SaveStorageBilletsToExcelFile(new ReportBindingModel { FileName = dialog.FileName });
                        MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FormReportStorageBillet_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                var dict = storageLogic.GetList();
                if (dict != null)
                {
                    dataGridView.Rows.Clear();
                    foreach (var storage in dict)
                    {
                        int billetsSum = 0;
                        dataGridView.Rows.Add(new object[] { storage.StorageName, "", "" });
                        foreach (var billet in storage.StorageBillets)
                        {
                            dataGridView.Rows.Add(new object[] { "", billet.BilletName, billet.Count });
                            billetsSum += billet.Count;
                        }
                        dataGridView.Rows.Add(new object[] { "Итого:", "", billetsSum });
                        dataGridView.Rows.Add(new object[] { });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}