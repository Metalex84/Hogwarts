namespace Hogwarts
{
    partial class Form1
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
            btn_loadFile = new Button();
            lbl_title = new Label();
            lbl_name = new Label();
            lbl_filename = new Label();
            btn_random = new Button();
            SuspendLayout();
            // 
            // btn_loadFile
            // 
            btn_loadFile.Location = new Point(48, 28);
            btn_loadFile.Name = "btn_loadFile";
            btn_loadFile.Size = new Size(111, 37);
            btn_loadFile.TabIndex = 0;
            btn_loadFile.Text = "Cargar archivo";
            btn_loadFile.UseVisualStyleBackColor = true;
            btn_loadFile.Click += btn_loadFile_Click;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_title.Location = new Point(259, 31);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(199, 25);
            lbl_title.TabIndex = 1;
            lbl_title.Text = "El alumno elegido es...";
            lbl_title.Click += lbl_title_Click;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_name.Location = new Point(259, 152);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(0, 21);
            lbl_name.TabIndex = 2;
            // 
            // lbl_filename
            // 
            lbl_filename.AutoSize = true;
            lbl_filename.Location = new Point(48, 91);
            lbl_filename.Name = "lbl_filename";
            lbl_filename.Size = new Size(16, 15);
            lbl_filename.TabIndex = 3;
            lbl_filename.Text = "...";
            lbl_filename.Click += label1_Click;
            // 
            // btn_random
            // 
            btn_random.Location = new Point(52, 173);
            btn_random.Name = "btn_random";
            btn_random.Size = new Size(107, 36);
            btn_random.TabIndex = 4;
            btn_random.Text = "Elegir";
            btn_random.UseVisualStyleBackColor = true;
            btn_random.Click += btn_random_Click;


            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 270);
            Controls.Add(btn_random);
            Controls.Add(lbl_filename);
            Controls.Add(lbl_name);
            Controls.Add(lbl_title);
            Controls.Add(btn_loadFile);
            Name = "Form1";
            Text = "Selector aleatorio de alumnos";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_loadFile;
        private Label lbl_title;
        private Label lbl_name;
        private Label lbl_filename;
        private Button btn_random;
    }
}
