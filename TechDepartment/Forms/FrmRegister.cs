using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TechDepartment.MyDbContext;
using TechDepartment.Entities;

namespace TechDepartment.Forms
{
    public partial class FrmRegister : MetroForm
    {
        private List<Coworker> _coworkers;

        public FrmRegister()
        {
            InitializeComponent();
        }

        public FrmRegister(List<Coworker> cw) :this()
        {
            _coworkers = cw;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            txtLastName.Text = txtLastName.Text.Replace(" ", "");
            txtFirstName.Text = txtFirstName.Text.Replace(" ", "");
            txtMiddleName.Text = txtMiddleName.Text.Replace(" ", "");

            if (txtLastName.Text == string.Empty || 
                txtFirstName.Text == string.Empty || 
                txtMiddleName.Text == string.Empty || 
                txtPN.Text == string.Empty ||
                txtLogin.Text == string.Empty ||
                txtPassword.Text == string.Empty ||
                txtRepeatPass.Text == string.Empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "Все поля должны быть заполнены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!txtPassword.Text.Equals(txtRepeatPass.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Пароли не совпадают", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(_coworkers.FirstOrDefault(x => x.Login == txtLogin.Text) != null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Пользователь с таким логином уже существует", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Coworker coworker = new Coworker(txtLogin.Text, txtPassword.Text, txtPN.Text, txtFirstName.Text, txtLastName.Text, txtMiddleName.Text, Enums.UserType.User);

            using (Context context = new Context())
            {
                try
                {
                    context.Coworkers.Add(coworker);
                    context.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, $"Пользователь {coworker.LastName} создан", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "Ошибка БД", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Close();
        }
    }
}
