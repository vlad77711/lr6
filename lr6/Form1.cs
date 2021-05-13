using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr6
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvPlane.AutoGenerateColumns = false;
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Назва Літака";
            gvPlane.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Country";
            column.Name = "Країна Відправлення";
            gvPlane.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Region";
            column.Name = "Країна Прибуття";
            gvPlane.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Population";
            column.Name = "Номер рейсу";
            gvPlane.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "YearIncome";
            column.Name = "Кількіть місць класу Clasic";
            gvPlane.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Square";
            column.Name = "Кількіть місць класу Lux";
            //column.Width = 150;
            gvPlane.Columns.Add(column);
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "HasPort";
            column.Name = "Обід";
          //  column.Width = 60;
            
           gvPlane.Columns.Add(column);
           bindSrcPlane.Add(new Plane ("Львів", "Україна", "Львівська обл.", 800000,
           2000, 400, false));
        }

        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Plane plane = new Plane();
            fPlane t = new fPlane(ref plane);
            if (t.ShowDialog() == DialogResult.OK)
            {
                bindSrcPlane.Add(plane);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Plane plane = (Plane)bindSrcPlane.List[bindSrcPlane.Position];
            fPlane ft = new fPlane(ref plane);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcPlane.List[bindSrcPlane.Position] = plane;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?",
"Видалення запису", MessageBoxButtons.OKCancel,
MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcPlane.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
"Очистити таблицю?\n\nВсі дані будуть втрачені",
"Очищення даних", MessageBoxButtons.OKCancel,
MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcPlane.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми",
MessageBoxButtons.OKCancel,
MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

       
    }
}
