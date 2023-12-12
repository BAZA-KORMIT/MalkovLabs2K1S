namespace QForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.Enq = new System.Windows.Forms.Button();
            this.Deq = new System.Windows.Forms.Button();
            this.Peek = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(66, 259);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(528, 161);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(266, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "отображение";
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(658, 154);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(87, 43);
            this.create.TabIndex = 2;
            this.create.Text = "create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // Enq
            // 
            this.Enq.Location = new System.Drawing.Point(83, 33);
            this.Enq.Name = "Enq";
            this.Enq.Size = new System.Drawing.Size(77, 38);
            this.Enq.TabIndex = 3;
            this.Enq.Text = "Enq";
            this.Enq.UseVisualStyleBackColor = true;
            this.Enq.Click += new System.EventHandler(this.Enq_Click);
            // 
            // Deq
            // 
            this.Deq.Location = new System.Drawing.Point(274, 38);
            this.Deq.Name = "Deq";
            this.Deq.Size = new System.Drawing.Size(86, 40);
            this.Deq.TabIndex = 4;
            this.Deq.Text = "Deq";
            this.Deq.UseVisualStyleBackColor = true;
            this.Deq.Click += new System.EventHandler(this.Deq_Click);
            // 
            // Peek
            // 
            this.Peek.Location = new System.Drawing.Point(455, 33);
            this.Peek.Name = "Peek";
            this.Peek.Size = new System.Drawing.Size(98, 46);
            this.Peek.TabIndex = 5;
            this.Peek.Text = "Peek";
            this.Peek.UseVisualStyleBackColor = true;
            this.Peek.Click += new System.EventHandler(this.Peek_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(642, 38);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(77, 40);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(557, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 23);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(66, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(95, 23);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(455, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(95, 23);
            this.textBox3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Peek);
            this.Controls.Add(this.Deq);
            this.Controls.Add(this.Enq);
            this.Controls.Add(this.create);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
        private Button create;
        private Button Enq;
        private Button Deq;
        private Button Peek;
        private Button Clear;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}