namespace refugeApp
{
    partial class form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            imageList1 = new ImageList(components);
            tabPage4 = new TabPage();
            tabPage3 = new TabPage();
            tabPage2 = new TabPage();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            lblTotalMenage = new MaterialSkin.Controls.MaterialLabel();
            materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            txtSearchMenage = new MaterialSkin.Controls.MaterialTextBox2();
            lstvMenage = new MaterialSkin.Controls.MaterialListView();
            tabPage1 = new TabPage();
            progressDeplaceAdulte = new ProgressBar();
            progressBarDeplaEnf = new ProgressBar();
            panel6 = new Panel();
            label8 = new Label();
            lblnbrDeplaceAdulte = new Label();
            panel5 = new Panel();
            label6 = new Label();
            lblNbrEnfant = new Label();
            panel4 = new Panel();
            progressBarDeplaceM = new ProgressBar();
            label4 = new Label();
            lblNbrDeplaceM = new Label();
            panel3 = new Panel();
            progressBarDeplaceF = new ProgressBar();
            label3 = new Label();
            lblNbrDeplaceF = new Label();
            panel2 = new Panel();
            progressBarDeplace = new ProgressBar();
            label1 = new Label();
            lblNbrDeplace = new Label();
            panel1 = new Panel();
            lblNbrMenage = new MaterialSkin.Controls.MaterialLabel();
            progressBarMenage = new ProgressBar();
            label2 = new Label();
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            materialTabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Black;
            imageList1.Images.SetKeyName(0, "home(1).png");
            imageList1.Images.SetKeyName(1, "house.png");
            imageList1.Images.SetKeyName(2, "crowd-of-users.png");
            imageList1.Images.SetKeyName(3, "add-group.png");
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.White;
            tabPage4.ImageIndex = 3;
            tabPage4.Location = new Point(4, 39);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1400, 683);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Agent recenseur";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.White;
            tabPage3.BackgroundImage = (Image)resources.GetObject("tabPage3.BackgroundImage");
            tabPage3.ImageIndex = 2;
            tabPage3.Location = new Point(4, 39);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1400, 683);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Deplacés";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(materialLabel1);
            tabPage2.Controls.Add(lblTotalMenage);
            tabPage2.Controls.Add(materialFloatingActionButton2);
            tabPage2.Controls.Add(materialFloatingActionButton1);
            tabPage2.Controls.Add(txtSearchMenage);
            tabPage2.Controls.Add(lstvMenage);
            tabPage2.ImageIndex = 1;
            tabPage2.Location = new Point(4, 39);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1400, 683);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Menages";
            tabPage2.Enter += tabPage2_Enter;
            // 
            // materialLabel1
            // 
            materialLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel1.Location = new Point(1131, 34);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(128, 24);
            materialLabel1.TabIndex = 4;
            materialLabel1.Text = "Nombre total :";
            // 
            // lblTotalMenage
            // 
            lblTotalMenage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTotalMenage.AutoSize = true;
            lblTotalMenage.Depth = 0;
            lblTotalMenage.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTotalMenage.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblTotalMenage.Location = new Point(1274, 34);
            lblTotalMenage.MouseState = MaterialSkin.MouseState.HOVER;
            lblTotalMenage.Name = "lblTotalMenage";
            lblTotalMenage.Size = new Size(12, 24);
            lblTotalMenage.TabIndex = 5;
            lblTotalMenage.Text = "0";
            // 
            // materialFloatingActionButton2
            // 
            materialFloatingActionButton2.Depth = 0;
            materialFloatingActionButton2.Icon = Properties.Resources.refresh;
            materialFloatingActionButton2.Location = new Point(364, 34);
            materialFloatingActionButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton2.Name = "materialFloatingActionButton2";
            materialFloatingActionButton2.Size = new Size(56, 56);
            materialFloatingActionButton2.TabIndex = 9;
            materialFloatingActionButton2.Text = "materialFloatingActionButton2";
            materialFloatingActionButton2.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton1
            // 
            materialFloatingActionButton1.Depth = 0;
            materialFloatingActionButton1.Icon = Properties.Resources.printing;
            materialFloatingActionButton1.Location = new Point(451, 34);
            materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            materialFloatingActionButton1.Size = new Size(62, 56);
            materialFloatingActionButton1.TabIndex = 7;
            materialFloatingActionButton1.Text = "materialFloatingActionButton1";
            materialFloatingActionButton1.UseVisualStyleBackColor = true;
            materialFloatingActionButton1.Click += materialFloatingActionButton1_Click;
            // 
            // txtSearchMenage
            // 
            txtSearchMenage.AnimateReadOnly = false;
            txtSearchMenage.BackgroundImageLayout = ImageLayout.None;
            txtSearchMenage.CharacterCasing = CharacterCasing.Normal;
            txtSearchMenage.Depth = 0;
            txtSearchMenage.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSearchMenage.HideSelection = true;
            txtSearchMenage.Hint = "Rechercher";
            txtSearchMenage.LeadingIcon = null;
            txtSearchMenage.Location = new Point(39, 34);
            txtSearchMenage.MaxLength = 32767;
            txtSearchMenage.MouseState = MaterialSkin.MouseState.OUT;
            txtSearchMenage.Name = "txtSearchMenage";
            txtSearchMenage.PasswordChar = '\0';
            txtSearchMenage.PrefixSuffixText = null;
            txtSearchMenage.ReadOnly = false;
            txtSearchMenage.RightToLeft = RightToLeft.No;
            txtSearchMenage.SelectedText = "";
            txtSearchMenage.SelectionLength = 0;
            txtSearchMenage.SelectionStart = 0;
            txtSearchMenage.ShortcutsEnabled = true;
            txtSearchMenage.Size = new Size(250, 48);
            txtSearchMenage.TabIndex = 6;
            txtSearchMenage.TabStop = false;
            txtSearchMenage.TextAlign = HorizontalAlignment.Left;
            txtSearchMenage.TrailingIcon = Properties.Resources.magnifier1;
            txtSearchMenage.UseSystemPasswordChar = false;
            txtSearchMenage.TextChanged += txtSearchMenage_TextChanged;
            // 
            // lstvMenage
            // 
            lstvMenage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstvMenage.AutoSizeTable = false;
            lstvMenage.BackColor = Color.FromArgb(255, 255, 255);
            lstvMenage.BorderStyle = BorderStyle.None;
            lstvMenage.Depth = 0;
            lstvMenage.FullRowSelect = true;
            lstvMenage.Location = new Point(22, 149);
            lstvMenage.MinimumSize = new Size(200, 100);
            lstvMenage.MouseLocation = new Point(-1, -1);
            lstvMenage.MouseState = MaterialSkin.MouseState.OUT;
            lstvMenage.Name = "lstvMenage";
            lstvMenage.OwnerDraw = true;
            lstvMenage.RightToLeft = RightToLeft.Yes;
            lstvMenage.Scrollable = false;
            lstvMenage.Size = new Size(1313, 459);
            lstvMenage.Sorting = SortOrder.Ascending;
            lstvMenage.TabIndex = 0;
            lstvMenage.UseCompatibleStateImageBehavior = false;
            lstvMenage.View = View.Details;
            lstvMenage.SelectedIndexChanged += lstvMenage_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(progressDeplaceAdulte);
            tabPage1.Controls.Add(progressBarDeplaEnf);
            tabPage1.Controls.Add(panel6);
            tabPage1.Controls.Add(panel5);
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.ImageIndex = 0;
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1400, 683);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Accueil";
            // 
            // progressDeplaceAdulte
            // 
            progressDeplaceAdulte.Location = new Point(687, 287);
            progressDeplaceAdulte.Name = "progressDeplaceAdulte";
            progressDeplaceAdulte.Size = new Size(228, 10);
            progressDeplaceAdulte.Style = ProgressBarStyle.Continuous;
            progressDeplaceAdulte.TabIndex = 2;
            progressDeplaceAdulte.Click += progressDeplaceAdulte_Click;
            // 
            // progressBarDeplaEnf
            // 
            progressBarDeplaEnf.Location = new Point(348, 287);
            progressBarDeplaEnf.Name = "progressBarDeplaEnf";
            progressBarDeplaEnf.Size = new Size(227, 10);
            progressBarDeplaEnf.Style = ProgressBarStyle.Continuous;
            progressBarDeplaEnf.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightSteelBlue;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label8);
            panel6.Controls.Add(lblnbrDeplaceAdulte);
            panel6.Location = new Point(687, 287);
            panel6.Name = "panel6";
            panel6.Size = new Size(228, 189);
            panel6.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(-1, 34);
            label8.Name = "label8";
            label8.Size = new Size(214, 15);
            label8.TabIndex = 1;
            label8.Text = "Nombre de  deplacés du genre Majeurs";
            // 
            // lblnbrDeplaceAdulte
            // 
            lblnbrDeplaceAdulte.AutoSize = true;
            lblnbrDeplaceAdulte.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            lblnbrDeplaceAdulte.Location = new Point(80, 77);
            lblnbrDeplaceAdulte.Name = "lblnbrDeplaceAdulte";
            lblnbrDeplaceAdulte.Size = new Size(0, 28);
            lblnbrDeplaceAdulte.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightSteelBlue;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label6);
            panel5.Controls.Add(lblNbrEnfant);
            panel5.Location = new Point(348, 287);
            panel5.Name = "panel5";
            panel5.Size = new Size(228, 189);
            panel5.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 62);
            label6.Name = "label6";
            label6.Size = new Size(165, 15);
            label6.TabIndex = 1;
            label6.Text = "Nombre de  deplacés Mineurs";
            // 
            // lblNbrEnfant
            // 
            lblNbrEnfant.AutoSize = true;
            lblNbrEnfant.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            lblNbrEnfant.Location = new Point(80, 77);
            lblNbrEnfant.Name = "lblNbrEnfant";
            lblNbrEnfant.Size = new Size(0, 28);
            lblNbrEnfant.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSteelBlue;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(progressBarDeplaceM);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(lblNbrDeplaceM);
            panel4.Location = new Point(33, 287);
            panel4.Name = "panel4";
            panel4.Size = new Size(228, 189);
            panel4.TabIndex = 11;
            // 
            // progressBarDeplaceM
            // 
            progressBarDeplaceM.Location = new Point(-1, -1);
            progressBarDeplaceM.Name = "progressBarDeplaceM";
            progressBarDeplaceM.Size = new Size(230, 10);
            progressBarDeplaceM.Style = ProgressBarStyle.Continuous;
            progressBarDeplaceM.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 48);
            label4.Name = "label4";
            label4.Size = new Size(214, 15);
            label4.TabIndex = 1;
            label4.Text = "Nombre de  deplacés du genre masulin";
            // 
            // lblNbrDeplaceM
            // 
            lblNbrDeplaceM.AutoSize = true;
            lblNbrDeplaceM.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            lblNbrDeplaceM.Location = new Point(80, 77);
            lblNbrDeplaceM.Name = "lblNbrDeplaceM";
            lblNbrDeplaceM.Size = new Size(0, 28);
            lblNbrDeplaceM.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSteelBlue;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(progressBarDeplaceF);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(lblNbrDeplaceF);
            panel3.Location = new Point(687, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(228, 189);
            panel3.TabIndex = 8;
            // 
            // progressBarDeplaceF
            // 
            progressBarDeplaceF.Location = new Point(-1, -1);
            progressBarDeplaceF.Name = "progressBarDeplaceF";
            progressBarDeplaceF.Size = new Size(228, 10);
            progressBarDeplaceF.Style = ProgressBarStyle.Continuous;
            progressBarDeplaceF.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 48);
            label3.Name = "label3";
            label3.Size = new Size(215, 15);
            label3.TabIndex = 1;
            label3.Text = "Nombre de  deplacés du genre Feminin";
            // 
            // lblNbrDeplaceF
            // 
            lblNbrDeplaceF.AutoSize = true;
            lblNbrDeplaceF.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            lblNbrDeplaceF.Location = new Point(80, 77);
            lblNbrDeplaceF.Name = "lblNbrDeplaceF";
            lblNbrDeplaceF.Size = new Size(0, 28);
            lblNbrDeplaceF.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(progressBarDeplace);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblNbrDeplace);
            panel2.Location = new Point(348, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 189);
            panel2.TabIndex = 7;
            // 
            // progressBarDeplace
            // 
            progressBarDeplace.Location = new Point(-1, -1);
            progressBarDeplace.Name = "progressBarDeplace";
            progressBarDeplace.Size = new Size(228, 10);
            progressBarDeplace.Style = ProgressBarStyle.Continuous;
            progressBarDeplace.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 48);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre de  deplacés";
            // 
            // lblNbrDeplace
            // 
            lblNbrDeplace.AutoSize = true;
            lblNbrDeplace.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            lblNbrDeplace.Location = new Point(80, 77);
            lblNbrDeplace.Name = "lblNbrDeplace";
            lblNbrDeplace.Size = new Size(0, 28);
            lblNbrDeplace.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblNbrMenage);
            panel1.Controls.Add(progressBarMenage);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(33, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 189);
            panel1.TabIndex = 6;
            // 
            // lblNbrMenage
            // 
            lblNbrMenage.AutoSize = true;
            lblNbrMenage.Depth = 0;
            lblNbrMenage.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblNbrMenage.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblNbrMenage.Location = new Point(91, 95);
            lblNbrMenage.MouseState = MaterialSkin.MouseState.HOVER;
            lblNbrMenage.Name = "lblNbrMenage";
            lblNbrMenage.Size = new Size(1, 0);
            lblNbrMenage.TabIndex = 3;
            // 
            // progressBarMenage
            // 
            progressBarMenage.Location = new Point(-1, -1);
            progressBarMenage.Name = "progressBarMenage";
            progressBarMenage.Size = new Size(230, 10);
            progressBarMenage.Style = ProgressBarStyle.Continuous;
            progressBarMenage.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 48);
            label2.Name = "label2";
            label2.Size = new Size(195, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre de menages pour deplacés";
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Controls.Add(tabPage3);
            materialTabControl1.Controls.Add(tabPage4);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.ShowToolTips = true;
            materialTabControl1.Size = new Size(1408, 726);
            materialTabControl1.TabIndex = 0;
            materialTabControl1.Selected += materialTabControl1_Selected;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 793);
            Controls.Add(materialTabControl1);
            DrawerAutoShow = true;
            DrawerHighlightWithAccent = false;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            DrawerWidth = 220;
            Name = "form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tableau de bord";
            Load += form1_Load;
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            materialTabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private TabPage tabPage4;
        private TabPage tabPage3;
        private TabPage tabPage2;
        private MaterialSkin.Controls.MaterialListView lstvMenage;
        private TabPage tabPage1;
        private ProgressBar progressDeplaceAdulte;
        private ProgressBar progressBarDeplaEnf;
        private Panel panel6;
        private Label label8;
        private Label lblnbrDeplaceAdulte;
        private Panel panel5;
        private Label label6;
        private Label lblNbrEnfant;
        private Panel panel4;
        private ProgressBar progressBarDeplaceM;
        private Label label4;
        private Label lblNbrDeplaceM;
        private Panel panel3;
        private ProgressBar progressBarDeplaceF;
        private Label label3;
        private Label lblNbrDeplaceF;
        private Panel panel2;
        private ProgressBar progressBarDeplace;
        private Label label1;
        private Label lblNbrDeplace;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialLabel lblNbrMenage;
        private ProgressBar progressBarMenage;
        private Label label2;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private MaterialSkin.Controls.MaterialLabel lblTotalMenage;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtSearchMenage;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private Panel panel7;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
    }
}
