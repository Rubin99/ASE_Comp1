namespace ASE_Comp1
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
            this.panel_Draw = new System.Windows.Forms.Panel();
            this.txt_MultiCmd = new System.Windows.Forms.TextBox();
            this.txt_Cmd = new System.Windows.Forms.TextBox();
            this.Run = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel_Draw
            // 
            this.panel_Draw.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_Draw.Location = new System.Drawing.Point(38, 33);
            this.panel_Draw.Name = "panel_Draw";
            this.panel_Draw.Size = new System.Drawing.Size(421, 373);
            this.panel_Draw.TabIndex = 0;
            this.panel_Draw.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Draw_Paint);
            this.panel_Draw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_Draw_MouseClick);
            // 
            // txt_MultiCmd
            // 
            this.txt_MultiCmd.Location = new System.Drawing.Point(485, 33);
            this.txt_MultiCmd.Multiline = true;
            this.txt_MultiCmd.Name = "txt_MultiCmd";
            this.txt_MultiCmd.Size = new System.Drawing.Size(291, 229);
            this.txt_MultiCmd.TabIndex = 1;
            // 
            // txt_Cmd
            // 
            this.txt_Cmd.Location = new System.Drawing.Point(485, 291);
            this.txt_Cmd.Name = "txt_Cmd";
            this.txt_Cmd.Size = new System.Drawing.Size(291, 22);
            this.txt_Cmd.TabIndex = 2;
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(588, 344);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(75, 23);
            this.Run.TabIndex = 3;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.txt_Cmd);
            this.Controls.Add(this.txt_MultiCmd);
            this.Controls.Add(this.panel_Draw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Draw;
        private System.Windows.Forms.TextBox txt_MultiCmd;
        private System.Windows.Forms.TextBox txt_Cmd;
        private System.Windows.Forms.Button Run;
    }
}

