using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using TechDepartment.MyDbContext;
using TechDepartment.Entities;
using TechDepartment.Enums;

namespace TechDepartment.Forms
{

    public partial class LoginForm : MetroForm
    {
        List<Coworker> _coworkers;

        public LoginForm()
        {
            InitializeComponent();
        }



        public static void Add()
        {
            using (var _context = new Context())
            {
                //_context.Coworkers.Add(new Coworker("login", "pass", "0", "FirstName", "LastName", "MiddleName", UserType.User));
                //_context.TaskTypes.Add(new TaskType("type", "CoworkerType"));
                //_context.Details.Add(new Detail("COdeDetail", "NameDetail"));
                //_context.Machines.Add(new Machine("NameMachine", "NoteMachine"));
                //_context.SaveChanges();

                for (int i = 0; i < 900000; i++)
                {
                    _context.Coworkers.Add(new Coworker("login" + i, "pass" + i, i.ToString(), "FirstName" + i, "LastName" + i, "MiddleName" + i, UserType.User));
                    _context.TaskTypes.Add(new TaskType("type" + i, "CoworkerType" + i));

                    _context.Details.Add(new Detail("COdeDetail" + i, "NameDetail" + i));
                    _context.Machines.Add(new Machine("NameMachine" + i, "NoteMachine" + i));
                    _context.AnotherTasks.Add(new AnotherTask(
                        DateTime.Now,
                        _context.Coworkers.First(x => x.Id != null))
                        );
                    //_context.ProgramJournals.Add(new ProgramJournal(
                    //    _context.Details.First(x => x.Id != null),
                    //    ";sakdhf;salaf;asdljbf;a" + i,
                    //    _context.Machines.First(x => x.Id != null),
                    //    i,
                    //    "safsdfasdfasdf" + i,
                    //    DateTime.Now,
                    //    ActStatus.Department,
                    //    _context.Coworkers.First(x => x.Id != null),
                    //    TPStatus.Minimum,
                    //    false,
                    //    false,
                    //    true,
                    //    true,
                    //    "safdfdfdfdfdfdfdfdlkjhasdflhsadkgfjlkgdasfldkasgflkjgsdaldsgfa;sdlgf;asdgfsa",
                    //    "safgasdfasfasgahashfsdfhsd;slghsdlk;gj"));
                    _context.ProgrammerReports.Add(new ProgrammerReport(
                        DateTime.Now,
                        _context.Coworkers.First(x => x.Id != null),
                        _context.TaskTypes.First(x => x.Id != null),
                        _context.Details.First(x => x.Id != null),
                        true,
                        true,
                        true,
                        true,
                        i,
                        i
                        ));
                    _context.TechnologistReports.Add(new TechnologistReport(
                        DateTime.Now,
                        _context.Coworkers.First(x => x.Id != null),
                        _context.TaskTypes.First(x => x.Id != null),
                        "asfkjlhadsfgalkjdsgfkjasdgflkgsdf",
                        "as;dfjh;gsjflkdsgf;djsgflkdshgfl;kdjhsfas"
                        ));

                    _context.SaveChanges();
                }
            }
        }


        private void UpdateList()
        {
            using (var context = new Context())
            {
                _coworkers = context.Coworkers.ToList();
            }
            checkGuest.Checked = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var form = new FrmRegister();
            Hide();
            if(form.ShowDialog() == DialogResult.OK)
                UpdateList();
            ClearForm();
            Show();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Add();
            UpdateList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearForm()
        {
            txtLogin.Text = "";
            txtPassword.Text = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;
            MainForm mainForm;
            Coworker cw;

            if (checkGuest.Checked)
            {
                mainForm = new MainForm(new Coworker("", "", "0000", "Гость", "Гость", "Гость", UserType.Guest));
                Hide();
                mainForm.ShowDialog();
                ClearForm();
                Show();
                return;
            }
            if (login == string.Empty || password == string.Empty)
            {
                MetroMessageBox.Show(this, "Все поля должны быть заполнены", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information, 150);
                return;
            }
            if (login.Equals("admin") && password.Equals("admin"))
            {
                mainForm = new MainForm(new Coworker("admin", "admin", "0000", "Admin", "Admin", "Admin", UserType.Admin));
                Hide();
                mainForm.ShowDialog();
                ClearForm();
                Show();
                return;
            }

            cw = _coworkers.FirstOrDefault(x => x.Login.Equals(login) && x.Password.Equals(password));
            if (cw == null)
            {
                MetroMessageBox.Show(this, "Неверная связка \"Логин\" - \"Пароль\"", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information, 150);
                return;
            }
            else
            {
                mainForm = new MainForm(cw);
            }
            Hide();
            mainForm.ShowDialog();
            ClearForm();
            Show();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnOk_Click(this, e);
        }

        private void checkGuest_CheckedChanged(object sender, EventArgs e)
        {
            if(checkGuest.Checked)
            {
                btnRegister.Enabled = false;
                txtLogin.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                btnRegister.Enabled = true;
                txtLogin.Enabled = true;
                txtPassword.Enabled = true;
            }
        }
    }
}
