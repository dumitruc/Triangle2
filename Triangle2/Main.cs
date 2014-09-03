using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Triangle1
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class frmTriangle : System.Windows.Forms.Form
    {
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPreselect;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusBar stbStatus;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtbResult;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private IContainer components;

        public frmTriangle()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();


            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTriangle));
            this.stbStatus = new System.Windows.Forms.StatusBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPreselect = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtbResult = new System.Windows.Forms.TextBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // stbStatus
            // 
            this.stbStatus.AccessibleDescription = null;
            this.stbStatus.AccessibleName = null;
            resources.ApplyResources(this.stbStatus, "stbStatus");
            this.stbStatus.BackgroundImage = null;
            this.stbStatus.Font = null;
            this.stbStatus.Name = "stbStatus";
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = null;
            this.groupBox1.AccessibleName = null;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackgroundImage = null;
            this.groupBox1.Controls.Add(this.cmbPreselect);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = null;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbPreselect
            // 
            this.cmbPreselect.AccessibleDescription = null;
            this.cmbPreselect.AccessibleName = null;
            resources.ApplyResources(this.cmbPreselect, "cmbPreselect");
            this.cmbPreselect.BackgroundImage = null;
            this.cmbPreselect.Font = null;
            this.cmbPreselect.Name = "cmbPreselect";
            this.cmbPreselect.SelectedIndexChanged += new System.EventHandler(this.cmbPreselect_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AccessibleDescription = null;
            this.radioButton1.AccessibleName = null;
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.BackgroundImage = null;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = null;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleDescription = null;
            this.groupBox2.AccessibleName = null;
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.BackgroundImage = null;
            this.groupBox2.Controls.Add(this.btnCheck);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.txtbResult);
            this.groupBox2.Font = null;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btnCheck
            // 
            this.btnCheck.AccessibleDescription = null;
            this.btnCheck.AccessibleName = null;
            resources.ApplyResources(this.btnCheck, "btnCheck");
            this.btnCheck.BackgroundImage = null;
            this.btnCheck.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCheck.Font = null;
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Click += new System.EventHandler(this.getSides);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleDescription = null;
            this.btnCancel.AccessibleName = null;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackgroundImage = null;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Click += new System.EventHandler(this.clear);
            // 
            // txtbResult
            // 
            this.txtbResult.AccessibleDescription = null;
            this.txtbResult.AccessibleName = null;
            resources.ApplyResources(this.txtbResult, "txtbResult");
            this.txtbResult.BackgroundImage = null;
            this.txtbResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbResult.Name = "txtbResult";
            this.txtbResult.ReadOnly = true;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
            resources.ApplyResources(this.mainMenu1, "mainMenu1");
            // 
            // menuItem1
            // 
            resources.ApplyResources(this.menuItem1, "menuItem1");
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem5,
            this.menuItem6,
            this.menuItem7});
            // 
            // menuItem5
            // 
            resources.ApplyResources(this.menuItem5, "menuItem5");
            this.menuItem5.Index = 0;
            this.menuItem5.Click += new System.EventHandler(this.clear);
            // 
            // menuItem6
            // 
            resources.ApplyResources(this.menuItem6, "menuItem6");
            this.menuItem6.Index = 1;
            this.menuItem6.Click += new System.EventHandler(this.getSides);
            // 
            // menuItem7
            // 
            resources.ApplyResources(this.menuItem7, "menuItem7");
            this.menuItem7.Index = 2;
            this.menuItem7.Click += new System.EventHandler(this.Exit);
            // 
            // menuItem2
            // 
            resources.ApplyResources(this.menuItem2, "menuItem2");
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3,
            this.menuItem4});
            // 
            // menuItem3
            // 
            resources.ApplyResources(this.menuItem3, "menuItem3");
            this.menuItem3.Index = 0;
            this.menuItem3.Click += new System.EventHandler(this.Help);
            // 
            // menuItem4
            // 
            resources.ApplyResources(this.menuItem4, "menuItem4");
            this.menuItem4.Index = 1;
            this.menuItem4.Click += new System.EventHandler(this.About);
            // 
            // frmTriangle
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.BackgroundImage = null;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.stbStatus);
            this.Font = null;
            this.Menu = this.mainMenu1;
            this.Name = "frmTriangle";
            this.Click += new System.EventHandler(this.SetRadio);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.frmTriangle_HelpRequested);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new frmTriangle());
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            stbStatus.Text = "...waiting for imput data";
            txtbResult.Text = "";
            cmbPreselect.Items.Add("3,3,3");
            cmbPreselect.Items.Add("3,4,5");
            cmbPreselect.Items.Add("3,4,3");

        }

        private void cmbPreselect_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, System.EventArgs e)
        {

        }
        private void checking(int a, int b, int c)
        {
            if (a == b || b == c || a == c)
            {
                if (a == b && c == b)
                {
                    //triunghi echilateral
                    txtbResult.Text = "Equilateral";
                    return;
                }
                txtbResult.Text = "Isosceles";
                stbStatus.Text = "These sides could form a triangle";
                return;
            }

            else if (a + b < c || b + c < a || a + c < b)
            {
                txtbResult.Text = "";
                stbStatus.Text = "These sides could not form a triangle";
                return;
            }
            else
            {
                txtbResult.Text = "Scalene";
                stbStatus.Text = "These sides could form a triangle";
                return;
            }
        }
        private void getSides(object sender, System.EventArgs e)
        {
            string alltext = cmbPreselect.Text;
            if (alltext == "")
            {
                MessageBox.Show("Please enter sides before checking!");
                return;
            }
            int end1 = alltext.IndexOf(",");
            int end2 = alltext.IndexOf(",", end1 + 1);
            int end3 = alltext.Length;
            int a = Convert.ToInt16(alltext.Substring(0, end1 - 0));
            int b = Convert.ToInt16(alltext.Substring(end1 + 1, end2 - end1 - 1));
            int c = Convert.ToInt16(alltext.Substring(end2 + 1, end3 - end2 - 1));
            checking(a, b, c);


        }

        private void clear(object sender, System.EventArgs e)
        {
            txtbResult.Text = "";
            stbStatus.Text = "";
            cmbPreselect.Text = "";
            radioButton1.Checked = false;
        }

        private void Exit(object sender, System.EventArgs e)
        {
            frmTriangle.ActiveForm.Close();
        }

        private void About(object sender, System.EventArgs e)
        {

            Form frmAb = new frmAbout();
            this.AddOwnedForm(frmAb);
            frmAb.Show();

        }
        private void Help(object sender, System.EventArgs e)
        {
            Form frmHelp = new frmHelpForm();
            this.AddOwnedForm(frmHelp);
            frmHelp.Show();
        }

    

        private void frmTriangle_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Form frmHelp = new frmHelpForm();
            this.AddOwnedForm(frmHelp);
            frmHelp.Show();
        }

        private void SetRadio(object sender, System.EventArgs e)
        {
            radioButton1.Checked = true;
        }

    }
}
