namespace BaiTapThucHanhBuoi1
{
    partial class MainForm
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
            label1 = new Label();
            txtTen = new TextBox();
            Xuly = new Button();
            btnCopy = new Button();
            txtSaoChep = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 93);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập tên của bạn";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(380, 90);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(163, 23);
            txtTen.TabIndex = 1;
            txtTen.TextChanged += textBox1_TextChanged;
            // 
            // Xuly
            // 
            Xuly.Location = new Point(380, 146);
            Xuly.Name = "Xuly";
            Xuly.Size = new Size(75, 23);
            Xuly.TabIndex = 2;
            Xuly.Text = "Xử lý";
            Xuly.UseVisualStyleBackColor = true;
            Xuly.Click += Xuly_Click;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(468, 146);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(75, 23);
            btnCopy.TabIndex = 3;
            btnCopy.Text = "Sao chép";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // txtSaoChep
            // 
            txtSaoChep.BorderStyle = BorderStyle.FixedSingle;
            txtSaoChep.Location = new Point(380, 215);
            txtSaoChep.Name = "txtSaoChep";
            txtSaoChep.ReadOnly = true;
            txtSaoChep.Size = new Size(163, 23);
            txtSaoChep.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 217);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 4;
            label2.Text = "Bạn đã nhập";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSaoChep);
            Controls.Add(label2);
            Controls.Add(btnCopy);
            Controls.Add(Xuly);
            Controls.Add(txtTen);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "sa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTen;
        private Button Xuly;
        private Button btnCopy;
        private TextBox txtSaoChep;
        private Label label2;
    }
}
