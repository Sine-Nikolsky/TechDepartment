using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using TechDepartment.Entities;

namespace TechDepartment.Forms
{
    public partial class MainForm : MetroForm
    {
        private Coworker _user;
        private List<MetroTabPage> _pages =  new List<MetroTabPage>();

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(Coworker coworker) : this()
        {
            _user = coworker;
        }

        private void HideTab()
        {
            foreach (MetroTabPage page in tabControl.TabPages)
            {
                tabControl.HideTab(page);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            if(_user.UserType == Enums.UserType.Admin)
            {
                Text += $". Добро пожаловать, {_user.ToString()}! (Администратор)";
            }
            if (_user.UserType == Enums.UserType.User)
            {
                Text += $". Добро пожаловать, {_user.ToString()}! (Пользователь)";
            }
            if (_user.UserType == Enums.UserType.Guest)
            {
                Text += $". Добро пожаловать, Гость";
            }
            foreach (MetroTabPage page in tabControl.TabPages)
            {
                _pages.Add(page);
                tabControl.HideTab(page);
            }
        }


        private void RefreshAllButtons()
        {
            tileDBManagement.Refresh();
            tileExcelParcers.Refresh();
            tileJournalsAndLists.Refresh();
            tilePlansAndGraphics.Refresh();
            tileReports.Refresh();
            tileWorkAnalysis.Refresh();
        }

        private void ChangeTab(object tile, EventArgs e)
        {
            MetroTile tmp = tile as MetroTile;

            switch (tmp.Name)
            {
                case "tileJournalsAndLists":
                    {
                        HideTab();
                        tmp.Style = MetroColorStyle.Brown;
                        tileReports.Style = MetroColorStyle.Orange;
                        tilePlansAndGraphics.Style = MetroColorStyle.Orange;
                        tileDBManagement.Style = MetroColorStyle.Orange;
                        tileWorkAnalysis.Style = MetroColorStyle.Orange;
                        tileExcelParcers.Style = MetroColorStyle.Orange;
                        RefreshAllButtons();

                        var tmp_list = _pages.Where(x => x.Name.Contains("ournal")).OrderByDescending(x => x.Text).ToList();
                        foreach (var i in tmp_list)
                            tabControl.ShowTab(i);
                        tabControl.SelectedTab = tmp_list[tmp_list.Count - 1];
                    }
                    break;
                case "tileReports":
                    {
                        HideTab();
                        tmp.Style = MetroColorStyle.Brown;
                        tileJournalsAndLists.Style = MetroColorStyle.Orange;
                        tilePlansAndGraphics.Style = MetroColorStyle.Orange;
                        tileDBManagement.Style = MetroColorStyle.Orange;
                        tileWorkAnalysis.Style = MetroColorStyle.Orange;
                        tileExcelParcers.Style = MetroColorStyle.Orange;
                        RefreshAllButtons();

                        var tmp_list = _pages.Where(x => x.Name.Contains("eport")).OrderByDescending(x => x.Text).ToList();
                        foreach (var i in tmp_list)
                            tabControl.ShowTab(i);
                        tabControl.SelectedTab = tmp_list[tmp_list.Count - 1];
                    }
                    break;
                case "tileDBManagement":
                    {
                        HideTab();
                        tmp.Style = MetroColorStyle.Brown;
                        tileReports.Style = MetroColorStyle.Orange;
                        tilePlansAndGraphics.Style = MetroColorStyle.Orange;
                        tileJournalsAndLists.Style = MetroColorStyle.Orange;
                        tileWorkAnalysis.Style = MetroColorStyle.Orange;
                        tileExcelParcers.Style = MetroColorStyle.Orange;
                        RefreshAllButtons();

                        var tmp_list = _pages.Where(x => x.Name.Contains("DB")).OrderByDescending(x => x.Text).ToList();
                        foreach (var i in tmp_list)
                            tabControl.ShowTab(i);
                        tabControl.SelectedTab = tmp_list[tmp_list.Count - 1];
                    }
                    break;
                case "tileWorkAnalysis":
                    {
                        HideTab();
                        tmp.Style = MetroColorStyle.Brown;
                        tileReports.Style = MetroColorStyle.Orange;
                        tileDBManagement.Style = MetroColorStyle.Orange;
                        tilePlansAndGraphics.Style = MetroColorStyle.Orange;
                        tileJournalsAndLists.Style = MetroColorStyle.Orange;
                        tileExcelParcers.Style = MetroColorStyle.Orange;
                        RefreshAllButtons(); 
                    }
                    break;
                case "tileExcelParcers":
                    {
                        HideTab();
                        tmp.Style = MetroColorStyle.Brown;
                        tileReports.Style = MetroColorStyle.Orange;
                        tilePlansAndGraphics.Style = MetroColorStyle.Orange;
                        tileDBManagement.Style = MetroColorStyle.Orange;
                        tileWorkAnalysis.Style = MetroColorStyle.Orange;
                        tileJournalsAndLists.Style = MetroColorStyle.Orange;
                        RefreshAllButtons();
                    }
                    break;
                case "tilePlansAndGraphics":
                    {
                        HideTab();
                        tmp.Style = MetroColorStyle.Brown;
                        tileReports.Style = MetroColorStyle.Orange;
                        tileExcelParcers.Style = MetroColorStyle.Orange;
                        tileDBManagement.Style = MetroColorStyle.Orange;
                        tileWorkAnalysis.Style = MetroColorStyle.Orange;
                        tileJournalsAndLists.Style = MetroColorStyle.Orange;
                        RefreshAllButtons();

                        var tmp_list = _pages.Where(x => x.Name.Contains("Plan")).OrderByDescending(x => x.Text).ToList();
                        foreach (var i in tmp_list)
                            tabControl.ShowTab(i);
                        tabControl.SelectedTab = tmp_list[tmp_list.Count - 1];
                    }
                    break;
            }
        }

        private void tabControl_Selected(object sender, System.Windows.Forms.TabControlEventArgs e)
        {
            var tmp = sender as MetroTabControl;
            switch (tmp.SelectedTab?.Name)
            {
                case "tabProgramJournal":
                    {

                    }
                    break;
                case "tabDetailDB":
                    {

                    }
                    break;
                case "tabCoworkerDB":
                    {

                    }
                    break;
                case "tabMachinesDB":
                    {

                    }
                    break;
                case "tabOEJournal":
                    {

                    }
                    break;
                case "tabTPJournal":
                    {

                    }
                    break;
                case "tabProgramReport":
                    {

                    }
                    break;
                case "tabTechnologistReport":
                    {

                    }
                    break;
                case "tabAnotherTaskReport":
                    {

                    }
                    break;
                case "tabSummaryProgramReport":
                    {

                    }
                    break;
                case "tabSummaryTechnologistReport":
                    {

                    }
                    break;
                case "tabPlanUP":
                    {

                    }
                    break;
                case "tabPlanTP":
                    {

                    }
                    break;
            }
        }
    }
}
