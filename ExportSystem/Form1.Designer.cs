namespace ExportSystem
{
    partial class Form1
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
            this.comboAlgorithms = new System.Windows.Forms.ComboBox();
            this.comboCompilations = new System.Windows.Forms.ComboBox();
            this.comboNotMicrosoft = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboAlgorithms
            // 
            this.comboAlgorithms.FormattingEnabled = true;
            this.comboAlgorithms.Items.AddRange(new object[] {
            "true",
            "false"});
            this.comboAlgorithms.Location = new System.Drawing.Point(231, 12);
            this.comboAlgorithms.Name = "comboAlgorithms";
            this.comboAlgorithms.Size = new System.Drawing.Size(121, 21);
            this.comboAlgorithms.TabIndex = 0;
            // 
            // comboCompilations
            // 
            this.comboCompilations.FormattingEnabled = true;
            this.comboCompilations.Items.AddRange(new object[] {
            "true",
            "false"});
            this.comboCompilations.Location = new System.Drawing.Point(231, 39);
            this.comboCompilations.Name = "comboCompilations";
            this.comboCompilations.Size = new System.Drawing.Size(121, 21);
            this.comboCompilations.TabIndex = 1;
            // 
            // comboNotMicrosoft
            // 
            this.comboNotMicrosoft.FormattingEnabled = true;
            this.comboNotMicrosoft.Items.AddRange(new object[] {
            "true",
            "false"});
            this.comboNotMicrosoft.Location = new System.Drawing.Point(231, 66);
            this.comboNotMicrosoft.Name = "comboNotMicrosoft";
            this.comboNotMicrosoft.Size = new System.Drawing.Size(121, 21);
            this.comboNotMicrosoft.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Do you like resolve complicated algorithms?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Do you really loved compilation?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Do you hate Microsoft technology?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(337, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Check it now!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 128);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboNotMicrosoft);
            this.Controls.Add(this.comboCompilations);
            this.Controls.Add(this.comboAlgorithms);
            this.MaximumSize = new System.Drawing.Size(388, 167);
            this.MinimumSize = new System.Drawing.Size(388, 167);
            this.Name = "Form1";
            this.Text = "Ultra advanced SI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboAlgorithms;
        private System.Windows.Forms.ComboBox comboCompilations;
        private System.Windows.Forms.ComboBox comboNotMicrosoft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

