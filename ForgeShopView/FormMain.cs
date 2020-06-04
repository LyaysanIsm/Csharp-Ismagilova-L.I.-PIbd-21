﻿using ForgeShopBusinessLogic.BindingModels;
using ForgeShopBusinessLogic.BusinessLogics;using ForgeShopBusinessLogic.Interfaces;
using System;
using System.Windows.Forms;
using Unity;

namespace ForgeShopView
{
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly MainLogic logic;
        private readonly IOrderLogic orderLogic;
        private readonly WorkModeling work;
        private readonly ReportLogic report;
        private readonly BackUpAbstractLogic backUpAbstractLogic;
        public FormMain(MainLogic logic, IOrderLogic orderLogic, WorkModeling work, ReportLogic report, BackUpAbstractLogic backUpAbstractLogic)
        {
            InitializeComponent();
            this.logic = logic;
            this.orderLogic = orderLogic;
            this.work = work;
            this.report = report;
            this.backUpAbstractLogic = backUpAbstractLogic;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                Program.ConfigGrid(orderLogic.Read(null), dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void BilletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormBillets>();
            form.ShowDialog();
        }
        private void ForgeProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormForgeProducts>();
            form.ShowDialog();
        }
        private void ClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormClients>();
            form.ShowDialog();
        }
        private void ImplementersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormImplementers>();
            form.ShowDialog();
        }
        private void ButtonCreateOrder_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormCreateOrder>();
            form.ShowDialog();
            LoadData();
        }
        private void ButtonPayOrder_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                try
                {
                    logic.PayOrder(new ChangeStatusBindingModel { OrderId = id });
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
        private void ButtonRef_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void ListOfForgeProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    report.SaveForgeProductsToWordFile(new ReportBindingModel
                    {
                        FileName =
                   dialog.FileName
                    });
                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                }
            }
        }
        private void ListOfOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormReportOrders>();
            form.ShowDialog();
        }
        private void ListForgeProductswithBilletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormReportForgeProductBillets>();
            form.ShowDialog();
        }
        private void ЗапускРаботToolStripMenuItem_Click(object sender, EventArgs e)
        {
            work.DoWork();
            LoadData();
        }

        private void MessagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormMessages>();
            form.ShowDialog();
        }

        private void СоздатьБэкапToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (backUpAbstractLogic != null)
                {
                    var fbd = new FolderBrowserDialog();
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        backUpAbstractLogic.CreateArchive(fbd.SelectedPath);
                        MessageBox.Show("Бекап создан", "Сообщение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
    }
}