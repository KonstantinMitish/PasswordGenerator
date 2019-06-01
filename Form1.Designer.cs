namespace PasswordGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_gen = new System.Windows.Forms.Button();
            this.nud_length = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.box_upper = new System.Windows.Forms.CheckBox();
            this.box_numbers = new System.Windows.Forms.CheckBox();
            this.box_rus = new System.Windows.Forms.CheckBox();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.box_rusUpper = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_length)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_gen
            // 
            this.btn_gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_gen.Location = new System.Drawing.Point(193, 7);
            this.btn_gen.Name = "btn_gen";
            this.btn_gen.Size = new System.Drawing.Size(213, 30);
            this.btn_gen.TabIndex = 0;
            this.btn_gen.Text = "Generate";
            this.btn_gen.UseVisualStyleBackColor = true;
            this.btn_gen.Click += new System.EventHandler(this.btn_gen_Click);
            // 
            // nud_length
            // 
            this.nud_length.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud_length.Location = new System.Drawing.Point(93, 7);
            this.nud_length.Maximum = new decimal(new int[] {
            239,
            0,
            0,
            0});
            this.nud_length.Name = "nud_length";
            this.nud_length.Size = new System.Drawing.Size(94, 30);
            this.nud_length.TabIndex = 1;
            this.nud_length.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Length";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // box_upper
            // 
            this.box_upper.AutoSize = true;
            this.box_upper.Checked = true;
            this.box_upper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.box_upper.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_upper.Location = new System.Drawing.Point(17, 43);
            this.box_upper.Name = "box_upper";
            this.box_upper.Size = new System.Drawing.Size(136, 29);
            this.box_upper.TabIndex = 3;
            this.box_upper.Text = "Upper Case";
            this.box_upper.UseVisualStyleBackColor = true;
            // 
            // box_numbers
            // 
            this.box_numbers.AutoSize = true;
            this.box_numbers.Checked = true;
            this.box_numbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.box_numbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_numbers.Location = new System.Drawing.Point(17, 78);
            this.box_numbers.Name = "box_numbers";
            this.box_numbers.Size = new System.Drawing.Size(110, 29);
            this.box_numbers.TabIndex = 4;
            this.box_numbers.Text = "Numbers";
            this.box_numbers.UseVisualStyleBackColor = true;
            // 
            // box_rus
            // 
            this.box_rus.AutoSize = true;
            this.box_rus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_rus.Location = new System.Drawing.Point(193, 78);
            this.box_rus.Name = "box_rus";
            this.box_rus.Size = new System.Drawing.Size(101, 29);
            this.box_rus.TabIndex = 5;
            this.box_rus.Text = "Russian";
            this.box_rus.UseVisualStyleBackColor = true;
            // 
            // txt_output
            // 
            this.txt_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_output.Location = new System.Drawing.Point(17, 113);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(389, 210);
            this.txt_output.TabIndex = 6;
            this.txt_output.TextChanged += new System.EventHandler(this.txt_output_TextChanged);
            // 
            // box_rusUpper
            // 
            this.box_rusUpper.AutoSize = true;
            this.box_rusUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_rusUpper.Location = new System.Drawing.Point(193, 43);
            this.box_rusUpper.Name = "box_rusUpper";
            this.box_rusUpper.Size = new System.Drawing.Size(159, 29);
            this.box_rusUpper.TabIndex = 5;
            this.box_rusUpper.Text = "Upper Russian";
            this.box_rusUpper.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 335);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.box_rusUpper);
            this.Controls.Add(this.box_rus);
            this.Controls.Add(this.box_numbers);
            this.Controls.Add(this.box_upper);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_length);
            this.Controls.Add(this.btn_gen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Генератор паролей  \"не твоя мама\" by KM6";
            ((System.ComponentModel.ISupportInitialize)(this.nud_length)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_gen;
        private System.Windows.Forms.NumericUpDown nud_length;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox box_upper;
        private System.Windows.Forms.CheckBox box_numbers;
        private System.Windows.Forms.CheckBox box_rus;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.CheckBox box_rusUpper;
    }
}

