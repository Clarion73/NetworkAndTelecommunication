namespace TextEncoderDecoder
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDecodedOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBinaryOutput = new System.Windows.Forms.TextBox();
            this.btnBinaryEncode = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(109, 12);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(223, 118);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(360, 18);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(105, 23);
            this.btnEncode.TabIndex = 1;
            this.btnEncode.Text = "Кодировать";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(360, 193);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(105, 23);
            this.btnDecode.TabIndex = 2;
            this.btnDecode.Text = "Декодировать";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(554, 19);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(306, 136);
            this.txtOutput.TabIndex = 3;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вывод :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ввод текста";
            // 
            // txtDecodedOutput
            // 
            this.txtDecodedOutput.Location = new System.Drawing.Point(554, 193);
            this.txtDecodedOutput.Multiline = true;
            this.txtDecodedOutput.Name = "txtDecodedOutput";
            this.txtDecodedOutput.ReadOnly = true;
            this.txtDecodedOutput.Size = new System.Drawing.Size(306, 152);
            this.txtDecodedOutput.TabIndex = 6;
            this.txtDecodedOutput.TextChanged += new System.EventHandler(this.txtDecodedOutput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Вывод :";
            // 
            // txtBinaryOutput
            // 
            this.txtBinaryOutput.Location = new System.Drawing.Point(554, 371);
            this.txtBinaryOutput.Multiline = true;
            this.txtBinaryOutput.Name = "txtBinaryOutput";
            this.txtBinaryOutput.ReadOnly = true;
            this.txtBinaryOutput.Size = new System.Drawing.Size(306, 152);
            this.txtBinaryOutput.TabIndex = 8;
            this.txtBinaryOutput.TextChanged += new System.EventHandler(this.txtBinaryOutput_TextChanged);
            // 
            // btnBinaryEncode
            // 
            this.btnBinaryEncode.Location = new System.Drawing.Point(360, 370);
            this.btnBinaryEncode.Name = "btnBinaryEncode";
            this.btnBinaryEncode.Size = new System.Drawing.Size(105, 44);
            this.btnBinaryEncode.TabIndex = 9;
            this.btnBinaryEncode.Text = "Двоичный код";
            this.btnBinaryEncode.UseVisualStyleBackColor = true;
            this.btnBinaryEncode.Click += new System.EventHandler(this.btnBinaryEncode_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Вывод :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 592);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBinaryEncode);
            this.Controls.Add(this.txtBinaryOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDecodedOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Text Encoder/Decoder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDecodedOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBinaryOutput;
        private System.Windows.Forms.Button btnBinaryEncode;
        private System.Windows.Forms.Label label4;
    }
}
