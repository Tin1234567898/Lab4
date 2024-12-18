using Lab4_4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         private void Form1_Load(object sender, EventArgs e)
        {
            dtpDat.Value = DateTime.Today;
            dtpGiao.Value = DateTime.Today;

            LoadData(dtpDat.Value, dtpGiao.Value);
        }

        private void LoadData(DateTime startDate, DateTime endDate)
        {
            try
            {
                using (var context = new ProductOrderContext())
                {
                    var invoices = context.Invoices
                        .Where(i => i.DeliveryDate >= startDate && i.DeliveryDate <= endDate)
                        .Select(i => new
                        {
                            i.InvoiceNo,
                            i.OrderDate,
                            i.DeliveryDate,
                            TotalAmount = i.Orders.Sum(o => o.Price * o.Quantity)
                        }).ToList();

                    if (invoices.Count > 0)
                    {
                        dgvOrders.Rows.Clear();
                        int stt = 1;
                        foreach (var invoice in invoices)
                        {
                            int rowIndex = dgvOrders.Rows.Add();
                            dgvOrders.Rows[rowIndex].Cells[0].Value = stt++;
                            dgvOrders.Rows[rowIndex].Cells[1].Value = invoice.InvoiceNo;
                            dgvOrders.Rows[rowIndex].Cells[2].Value = invoice.OrderDate.ToString("dd/MM/yyyy");
                            dgvOrders.Rows[rowIndex].Cells[3].Value = invoice.DeliveryDate.ToString("dd/MM/yyyy");
                            dgvOrders.Rows[rowIndex].Cells[4].Value = invoice.TotalAmount;
                        }
                        txtTotal.Text = invoices.Sum(i => i.TotalAmount).ToString("N0");
                    }
                    else
                    {
                        dgvOrders.Rows.Clear();
                        txtTotal.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void chkView_CheckedChanged(object sender, EventArgs e)
        {
            if (chkView.Checked)
            {
                DateTime startDate = dtpDat.Value;
                DateTime endDate = new DateTime(startDate.Year, startDate.Month, DateTime.DaysInMonth(startDate.Year, startDate.Month));

                if (startDate > endDate)
                {
                    MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                LoadData(startDate, endDate);
            }
            else
            {
                dtpDat_ValueChanged(sender, e);
                dtpGiao_ValueChanged(sender, e);
            }
        }

        private void dtpDat_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dtpDat.Value;
            DateTime endDate = dtpGiao.Value;

            if (startDate > endDate)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadData(startDate, endDate);
        }

        private void dtpGiao_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dtpDat.Value;
            DateTime endDate = dtpGiao.Value;

            if (startDate > endDate)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadData(startDate, endDate);
        }
    }
}
