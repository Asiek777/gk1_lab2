namespace gk1_lab2
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bumpGroupBox = new System.Windows.Forms.GroupBox();
            this.bumpMapBut = new System.Windows.Forms.Button();
            this.bumpMapPictureBox = new System.Windows.Forms.PictureBox();
            this.bumpMapRadioBut = new System.Windows.Forms.RadioButton();
            this.constVectorRadioBut = new System.Windows.Forms.RadioButton();
            this.textureGroupBox = new System.Windows.Forms.GroupBox();
            this.constColorBut = new System.Windows.Forms.Button();
            this.textureButton = new System.Windows.Forms.Button();
            this.texturePictureBox = new System.Windows.Forms.PictureBox();
            this.constColorPictureBox = new System.Windows.Forms.PictureBox();
            this.textureRadioButton = new System.Windows.Forms.RadioButton();
            this.colorRadioButton = new System.Windows.Forms.RadioButton();
            this.Light = new System.Windows.Forms.GroupBox();
            this.lightColorBut = new System.Windows.Forms.Button();
            this.lightColorBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.constLightRadioButton = new System.Windows.Forms.RadioButton();
            this.circleLightRadioButton = new System.Windows.Forms.RadioButton();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.disturbanceGroupBox = new System.Windows.Forms.GroupBox();
            this.disturbanceButton = new System.Windows.Forms.Button();
            this.disturbancePictureBox = new System.Windows.Forms.PictureBox();
            this.disturbanceRadioBut = new System.Windows.Forms.RadioButton();
            this.noDisturbanceRadioBut = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bumpGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bumpMapPictureBox)).BeginInit();
            this.textureGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.texturePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.constColorPictureBox)).BeginInit();
            this.Light.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lightColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.disturbanceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disturbancePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 850F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1064, 772);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.disturbanceGroupBox);
            this.panel1.Controls.Add(this.bumpGroupBox);
            this.panel1.Controls.Add(this.textureGroupBox);
            this.panel1.Controls.Add(this.Light);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(853, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 766);
            this.panel1.TabIndex = 0;
            // 
            // bumpGroupBox
            // 
            this.bumpGroupBox.Controls.Add(this.bumpMapBut);
            this.bumpGroupBox.Controls.Add(this.bumpMapPictureBox);
            this.bumpGroupBox.Controls.Add(this.bumpMapRadioBut);
            this.bumpGroupBox.Controls.Add(this.constVectorRadioBut);
            this.bumpGroupBox.Location = new System.Drawing.Point(12, 360);
            this.bumpGroupBox.Name = "bumpGroupBox";
            this.bumpGroupBox.Size = new System.Drawing.Size(187, 134);
            this.bumpGroupBox.TabIndex = 2;
            this.bumpGroupBox.TabStop = false;
            this.bumpGroupBox.Text = "Bump Mapping";
            // 
            // bumpMapBut
            // 
            this.bumpMapBut.Location = new System.Drawing.Point(127, 75);
            this.bumpMapBut.Name = "bumpMapBut";
            this.bumpMapBut.Size = new System.Drawing.Size(54, 38);
            this.bumpMapBut.TabIndex = 6;
            this.bumpMapBut.Text = "Set";
            this.bumpMapBut.UseVisualStyleBackColor = true;
            this.bumpMapBut.Click += new System.EventHandler(this.bumpMapBut_Click);
            // 
            // bumpMapPictureBox
            // 
            this.bumpMapPictureBox.Location = new System.Drawing.Point(83, 75);
            this.bumpMapPictureBox.Name = "bumpMapPictureBox";
            this.bumpMapPictureBox.Size = new System.Drawing.Size(38, 37);
            this.bumpMapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bumpMapPictureBox.TabIndex = 6;
            this.bumpMapPictureBox.TabStop = false;
            // 
            // bumpMapRadioBut
            // 
            this.bumpMapRadioBut.Location = new System.Drawing.Point(9, 75);
            this.bumpMapRadioBut.Name = "bumpMapRadioBut";
            this.bumpMapRadioBut.Size = new System.Drawing.Size(71, 38);
            this.bumpMapRadioBut.TabIndex = 2;
            this.bumpMapRadioBut.Text = "Bump Map";
            this.bumpMapRadioBut.UseVisualStyleBackColor = true;
            // 
            // constVectorRadioBut
            // 
            this.constVectorRadioBut.Checked = true;
            this.constVectorRadioBut.Location = new System.Drawing.Point(9, 30);
            this.constVectorRadioBut.Name = "constVectorRadioBut";
            this.constVectorRadioBut.Size = new System.Drawing.Size(94, 38);
            this.constVectorRadioBut.TabIndex = 1;
            this.constVectorRadioBut.TabStop = true;
            this.constVectorRadioBut.Text = "Constant Vector (0,0,1)";
            this.constVectorRadioBut.UseVisualStyleBackColor = true;
            this.constVectorRadioBut.CheckedChanged += new System.EventHandler(this.constVectorRadioBut_CheckedChanged);
            // 
            // textureGroupBox
            // 
            this.textureGroupBox.Controls.Add(this.constColorBut);
            this.textureGroupBox.Controls.Add(this.textureButton);
            this.textureGroupBox.Controls.Add(this.texturePictureBox);
            this.textureGroupBox.Controls.Add(this.constColorPictureBox);
            this.textureGroupBox.Controls.Add(this.textureRadioButton);
            this.textureGroupBox.Controls.Add(this.colorRadioButton);
            this.textureGroupBox.Location = new System.Drawing.Point(12, 199);
            this.textureGroupBox.Name = "textureGroupBox";
            this.textureGroupBox.Size = new System.Drawing.Size(187, 155);
            this.textureGroupBox.TabIndex = 1;
            this.textureGroupBox.TabStop = false;
            this.textureGroupBox.Text = "Texture";
            // 
            // constColorBut
            // 
            this.constColorBut.Location = new System.Drawing.Point(128, 41);
            this.constColorBut.Name = "constColorBut";
            this.constColorBut.Size = new System.Drawing.Size(53, 39);
            this.constColorBut.TabIndex = 5;
            this.constColorBut.Text = "Change";
            this.constColorBut.UseVisualStyleBackColor = true;
            this.constColorBut.Click += new System.EventHandler(this.constColorBut_Click);
            // 
            // textureButton
            // 
            this.textureButton.Location = new System.Drawing.Point(127, 85);
            this.textureButton.Name = "textureButton";
            this.textureButton.Size = new System.Drawing.Size(54, 38);
            this.textureButton.TabIndex = 4;
            this.textureButton.Text = "Set";
            this.textureButton.UseVisualStyleBackColor = true;
            this.textureButton.Click += new System.EventHandler(this.textureButton_Click);
            // 
            // texturePictureBox
            // 
            this.texturePictureBox.Location = new System.Drawing.Point(83, 85);
            this.texturePictureBox.Name = "texturePictureBox";
            this.texturePictureBox.Size = new System.Drawing.Size(38, 37);
            this.texturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.texturePictureBox.TabIndex = 3;
            this.texturePictureBox.TabStop = false;
            // 
            // constColorPictureBox
            // 
            this.constColorPictureBox.Location = new System.Drawing.Point(83, 42);
            this.constColorPictureBox.Name = "constColorPictureBox";
            this.constColorPictureBox.Size = new System.Drawing.Size(39, 37);
            this.constColorPictureBox.TabIndex = 2;
            this.constColorPictureBox.TabStop = false;
            // 
            // textureRadioButton
            // 
            this.textureRadioButton.Location = new System.Drawing.Point(9, 86);
            this.textureRadioButton.Name = "textureRadioButton";
            this.textureRadioButton.Size = new System.Drawing.Size(68, 37);
            this.textureRadioButton.TabIndex = 1;
            this.textureRadioButton.Text = "Texture Color";
            this.textureRadioButton.UseVisualStyleBackColor = true;
            // 
            // colorRadioButton
            // 
            this.colorRadioButton.Checked = true;
            this.colorRadioButton.Location = new System.Drawing.Point(9, 42);
            this.colorRadioButton.Name = "colorRadioButton";
            this.colorRadioButton.Size = new System.Drawing.Size(68, 38);
            this.colorRadioButton.TabIndex = 0;
            this.colorRadioButton.TabStop = true;
            this.colorRadioButton.Text = "Constant Color";
            this.colorRadioButton.UseVisualStyleBackColor = true;
            this.colorRadioButton.CheckedChanged += new System.EventHandler(this.colorRadioButton_CheckedChanged);
            // 
            // Light
            // 
            this.Light.Controls.Add(this.circleLightRadioButton);
            this.Light.Controls.Add(this.constLightRadioButton);
            this.Light.Controls.Add(this.lightColorBut);
            this.Light.Controls.Add(this.lightColorBox);
            this.Light.Controls.Add(this.label1);
            this.Light.Location = new System.Drawing.Point(12, 9);
            this.Light.Name = "Light";
            this.Light.Size = new System.Drawing.Size(187, 184);
            this.Light.TabIndex = 0;
            this.Light.TabStop = false;
            this.Light.Text = "Light";
            // 
            // lightColorBut
            // 
            this.lightColorBut.Location = new System.Drawing.Point(97, 37);
            this.lightColorBut.Name = "lightColorBut";
            this.lightColorBut.Size = new System.Drawing.Size(84, 40);
            this.lightColorBut.TabIndex = 2;
            this.lightColorBut.Text = "Change";
            this.lightColorBut.UseVisualStyleBackColor = true;
            this.lightColorBut.Click += new System.EventHandler(this.lightColorBut_Click);
            // 
            // lightColorBox
            // 
            this.lightColorBox.BackColor = System.Drawing.Color.White;
            this.lightColorBox.Location = new System.Drawing.Point(48, 37);
            this.lightColorBox.Name = "lightColorBox";
            this.lightColorBox.Size = new System.Drawing.Size(43, 40);
            this.lightColorBox.TabIndex = 1;
            this.lightColorBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Light Color";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(844, 766);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // constLightRadioButton
            // 
            this.constLightRadioButton.Location = new System.Drawing.Point(9, 83);
            this.constLightRadioButton.Name = "constLightRadioButton";
            this.constLightRadioButton.Size = new System.Drawing.Size(94, 38);
            this.constLightRadioButton.TabIndex = 3;
            this.constLightRadioButton.Text = "Constant Vector (0,0,1)";
            this.constLightRadioButton.UseVisualStyleBackColor = true;
            this.constLightRadioButton.CheckedChanged += new System.EventHandler(this.constLightRadioButton_CheckedChanged);
            // 
            // circleLightRadioButton
            // 
            this.circleLightRadioButton.Checked = true;
            this.circleLightRadioButton.Location = new System.Drawing.Point(9, 127);
            this.circleLightRadioButton.Name = "circleLightRadioButton";
            this.circleLightRadioButton.Size = new System.Drawing.Size(112, 38);
            this.circleLightRadioButton.TabIndex = 4;
            this.circleLightRadioButton.TabStop = true;
            this.circleLightRadioButton.Text = "Light on the circle of radius 200";
            this.circleLightRadioButton.UseVisualStyleBackColor = true;
            // 
            // refreshTimer
            // 
            this.refreshTimer.Enabled = true;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // disturbanceGroupBox
            // 
            this.disturbanceGroupBox.Controls.Add(this.noDisturbanceRadioBut);
            this.disturbanceGroupBox.Controls.Add(this.disturbanceButton);
            this.disturbanceGroupBox.Controls.Add(this.disturbancePictureBox);
            this.disturbanceGroupBox.Controls.Add(this.disturbanceRadioBut);
            this.disturbanceGroupBox.Location = new System.Drawing.Point(12, 500);
            this.disturbanceGroupBox.Name = "disturbanceGroupBox";
            this.disturbanceGroupBox.Size = new System.Drawing.Size(187, 139);
            this.disturbanceGroupBox.TabIndex = 7;
            this.disturbanceGroupBox.TabStop = false;
            this.disturbanceGroupBox.Text = "Bump Mapping";
            // 
            // disturbanceButton
            // 
            this.disturbanceButton.Location = new System.Drawing.Point(128, 72);
            this.disturbanceButton.Name = "disturbanceButton";
            this.disturbanceButton.Size = new System.Drawing.Size(54, 38);
            this.disturbanceButton.TabIndex = 6;
            this.disturbanceButton.Text = "Set";
            this.disturbanceButton.UseVisualStyleBackColor = true;
            // 
            // disturbancePictureBox
            // 
            this.disturbancePictureBox.Location = new System.Drawing.Point(83, 73);
            this.disturbancePictureBox.Name = "disturbancePictureBox";
            this.disturbancePictureBox.Size = new System.Drawing.Size(38, 37);
            this.disturbancePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.disturbancePictureBox.TabIndex = 6;
            this.disturbancePictureBox.TabStop = false;
            // 
            // disturbanceRadioBut
            // 
            this.disturbanceRadioBut.Location = new System.Drawing.Point(6, 73);
            this.disturbanceRadioBut.Name = "disturbanceRadioBut";
            this.disturbanceRadioBut.Size = new System.Drawing.Size(85, 38);
            this.disturbanceRadioBut.TabIndex = 2;
            this.disturbanceRadioBut.Text = "Disturbance Map";
            this.disturbanceRadioBut.UseVisualStyleBackColor = true;
            // 
            // noDisturbanceRadioBut
            // 
            this.noDisturbanceRadioBut.Checked = true;
            this.noDisturbanceRadioBut.Location = new System.Drawing.Point(9, 29);
            this.noDisturbanceRadioBut.Name = "noDisturbanceRadioBut";
            this.noDisturbanceRadioBut.Size = new System.Drawing.Size(94, 38);
            this.noDisturbanceRadioBut.TabIndex = 7;
            this.noDisturbanceRadioBut.TabStop = true;
            this.noDisturbanceRadioBut.Text = "No Disturbance";
            this.noDisturbanceRadioBut.UseVisualStyleBackColor = true;
            this.noDisturbanceRadioBut.CheckedChanged += new System.EventHandler(this.noDisturbanceRadioBut_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 772);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1080, 810);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.bumpGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bumpMapPictureBox)).EndInit();
            this.textureGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.texturePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.constColorPictureBox)).EndInit();
            this.Light.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lightColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.disturbanceGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.disturbancePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox Light;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.PictureBox lightColorBox;
        private System.Windows.Forms.Button lightColorBut;
        private System.Windows.Forms.GroupBox textureGroupBox;
        private System.Windows.Forms.RadioButton textureRadioButton;
        private System.Windows.Forms.RadioButton colorRadioButton;
        private System.Windows.Forms.Button constColorBut;
        private System.Windows.Forms.Button textureButton;
        internal System.Windows.Forms.PictureBox texturePictureBox;
        internal System.Windows.Forms.PictureBox constColorPictureBox;
        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox bumpGroupBox;
        private System.Windows.Forms.Button bumpMapBut;
        internal System.Windows.Forms.PictureBox bumpMapPictureBox;
        private System.Windows.Forms.RadioButton bumpMapRadioBut;
        private System.Windows.Forms.RadioButton constVectorRadioBut;
        private System.Windows.Forms.RadioButton circleLightRadioButton;
        private System.Windows.Forms.RadioButton constLightRadioButton;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.GroupBox disturbanceGroupBox;
        private System.Windows.Forms.RadioButton noDisturbanceRadioBut;
        private System.Windows.Forms.Button disturbanceButton;
        internal System.Windows.Forms.PictureBox disturbancePictureBox;
        private System.Windows.Forms.RadioButton disturbanceRadioBut;
    }
}

