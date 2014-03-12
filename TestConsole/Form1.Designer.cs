namespace TestConsole
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.ledView1 = new RobotView.LedView();
            this.ledView2 = new RobotView.LedView();
            this.ledView3 = new RobotView.LedView();
            this.ledView4 = new RobotView.LedView();
            this.SuspendLayout();
            // 
            // ledView1
            // 
            this.ledView1.Location = new System.Drawing.Point(226, 119);
            this.ledView1.Name = "ledView1";
            this.ledView1.Size = new System.Drawing.Size(20, 20);
            this.ledView1.TabIndex = 0;
            // 
            // ledView2
            // 
            this.ledView2.Location = new System.Drawing.Point(452, 82);
            this.ledView2.Name = "ledView2";
            this.ledView2.Size = new System.Drawing.Size(20, 20);
            this.ledView2.TabIndex = 1;
            // 
            // ledView3
            // 
            this.ledView3.Location = new System.Drawing.Point(476, 50);
            this.ledView3.Name = "ledView3";
            this.ledView3.Size = new System.Drawing.Size(20, 20);
            this.ledView3.TabIndex = 2;
            // 
            // ledView4
            // 
            this.ledView4.Location = new System.Drawing.Point(253, 119);
            this.ledView4.Name = "ledView4";
            this.ledView4.Size = new System.Drawing.Size(20, 20);
            this.ledView4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.ledView4);
            this.Controls.Add(this.ledView3);
            this.Controls.Add(this.ledView2);
            this.Controls.Add(this.ledView1);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RobotView.LedView ledView1;
        private RobotView.LedView ledView2;
        private RobotView.LedView ledView3;
        private RobotView.LedView ledView4;
    }
}

