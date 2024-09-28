namespace Elevara
{
    public partial class Layout : Form
    {
        public Layout()
        {
            InitializeComponent();
            CustomiseDesign();
        }

        private void CustomiseDesign()
        {
            panelAdminOperatives.Visible = false;
            panelAgentOperatives.Visible = false;
        }
        private void HideSubMenus()
        {
            if (panelAdminOperatives.Visible == true)
            {
                panelAdminOperatives.Visible = false;
            }
            if (panelAgentOperatives.Visible == true)
            {
                panelAgentOperatives.Visible = false;
            }
        }
        private void ShowSubMenus(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void BtnAdminOperatives_Click(object sender, EventArgs e)
        {
            ShowSubMenus(panelAdminOperatives);
        }

        private void SubmenuAdminApproval_Click(object sender, EventArgs e)
        {
            //codeLogic
            OpenChildForm(new Approval());
            //
        }

        private void SubmenuAdminAccessControl_Click(object sender, EventArgs e)
        {
            //codeLogic
        }

        private void SubmenuActionDetails_Click(object sender, EventArgs e)
        {
            //codeLogic
        }

        private void SubmenuAdminDetails_Click(object sender, EventArgs e)
        {
            //codeLogic
        }

        private void BtnOperativesMenu_Click(object sender, EventArgs e)
        {
            ShowSubMenus(panelAgentOperatives);
        }

        private void SubmenuAgentApproval_Click(object sender, EventArgs e)
        {
            //codeLogic
        }

        private void SubmenuAgentAccessControl_Click(object sender, EventArgs e)
        {
            //codeLogic
        }

        private void SubmenuAgentCurrentStatus_Click(object sender, EventArgs e)
        {
            //codeLogic
        }

        private void SubmenuAgentDetails_Click(object sender, EventArgs e)
        {
            //codeLogic
        }
        private Form? activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            activeForm?.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Label_AppName_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                if (form != this)
                {
                    form.Close();
                }
            }
            HideSubMenus();

        }

        private void PanelNaigation_Click(object sender, EventArgs e)
        {
            HideSubMenus();
        }
    }
}
