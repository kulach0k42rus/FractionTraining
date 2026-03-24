namespace FractionTraining
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
            this.task_lbl = new System.Windows.Forms.Label();
            this.ok_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.result_lbl = new System.Windows.Forms.Label();
            this.answ_lbl = new System.Windows.Forms.Label();
            this.task_rtb = new System.Windows.Forms.RichTextBox();
            this.numRes_lbl = new System.Windows.Forms.Label();
            this.denomRes_lbl = new System.Windows.Forms.Label();
            this.num_tb = new System.Windows.Forms.TextBox();
            this.denom_tb = new System.Windows.Forms.TextBox();
            this.count_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // task_lbl
            // 
            this.task_lbl.AutoSize = true;
            this.task_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task_lbl.Location = new System.Drawing.Point(9, 9);
            this.task_lbl.Name = "task_lbl";
            this.task_lbl.Size = new System.Drawing.Size(111, 24);
            this.task_lbl.TabIndex = 0;
            this.task_lbl.Text = "Сократить:";
            // 
            // ok_btn
            // 
            this.ok_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ok_btn.Location = new System.Drawing.Point(12, 133);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(112, 46);
            this.ok_btn.TabIndex = 1;
            this.ok_btn.Text = "Ok";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(270, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "----------";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // result_lbl
            // 
            this.result_lbl.AutoSize = true;
            this.result_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_lbl.Location = new System.Drawing.Point(12, 182);
            this.result_lbl.Name = "result_lbl";
            this.result_lbl.Size = new System.Drawing.Size(0, 25);
            this.result_lbl.TabIndex = 5;
            // 
            // answ_lbl
            // 
            this.answ_lbl.AutoSize = true;
            this.answ_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answ_lbl.Location = new System.Drawing.Point(264, 9);
            this.answ_lbl.Name = "answ_lbl";
            this.answ_lbl.Size = new System.Drawing.Size(72, 24);
            this.answ_lbl.TabIndex = 6;
            this.answ_lbl.Text = "Ответ:";
            // 
            // task_rtb
            // 
            this.task_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task_rtb.Location = new System.Drawing.Point(12, 41);
            this.task_rtb.Name = "task_rtb";
            this.task_rtb.ReadOnly = true;
            this.task_rtb.Size = new System.Drawing.Size(212, 86);
            this.task_rtb.TabIndex = 10;
            this.task_rtb.Text = "";
            // 
            // numRes_lbl
            // 
            this.numRes_lbl.AutoSize = true;
            this.numRes_lbl.Location = new System.Drawing.Point(483, 17);
            this.numRes_lbl.Name = "numRes_lbl";
            this.numRes_lbl.Size = new System.Drawing.Size(0, 13);
            this.numRes_lbl.TabIndex = 11;
            // 
            // denomRes_lbl
            // 
            this.denomRes_lbl.AutoSize = true;
            this.denomRes_lbl.Location = new System.Drawing.Point(483, 59);
            this.denomRes_lbl.Name = "denomRes_lbl";
            this.denomRes_lbl.Size = new System.Drawing.Size(0, 13);
            this.denomRes_lbl.TabIndex = 12;
            // 
            // num_tb
            // 
            this.num_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num_tb.Location = new System.Drawing.Point(268, 41);
            this.num_tb.Name = "num_tb";
            this.num_tb.Size = new System.Drawing.Size(42, 31);
            this.num_tb.TabIndex = 13;
            this.num_tb.TextChanged += new System.EventHandler(this.num_tb_TextChanged);
            this.num_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_tb_KeyPress);
            // 
            // denom_tb
            // 
            this.denom_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.denom_tb.Location = new System.Drawing.Point(268, 96);
            this.denom_tb.Name = "denom_tb";
            this.denom_tb.Size = new System.Drawing.Size(42, 31);
            this.denom_tb.TabIndex = 14;
            this.denom_tb.TextChanged += new System.EventHandler(this.num_tb_TextChanged);
            this.denom_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_tb_KeyPress);
            // 
            // count_lbl
            // 
            this.count_lbl.AutoSize = true;
            this.count_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_lbl.Location = new System.Drawing.Point(139, 15);
            this.count_lbl.Name = "count_lbl";
            this.count_lbl.Size = new System.Drawing.Size(70, 16);
            this.count_lbl.TabIndex = 15;
            this.count_lbl.Text = "Решено: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(366, 239);
            this.Controls.Add(this.count_lbl);
            this.Controls.Add(this.denom_tb);
            this.Controls.Add(this.num_tb);
            this.Controls.Add(this.denomRes_lbl);
            this.Controls.Add(this.numRes_lbl);
            this.Controls.Add(this.task_rtb);
            this.Controls.Add(this.answ_lbl);
            this.Controls.Add(this.result_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.task_lbl);
            this.Name = "Form1";
            this.Text = "Тренажер дробей";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label task_lbl;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label result_lbl;
        private System.Windows.Forms.Label answ_lbl;
        private System.Windows.Forms.RichTextBox task_rtb;
        private System.Windows.Forms.Label numRes_lbl;
        private System.Windows.Forms.Label denomRes_lbl;
        private System.Windows.Forms.TextBox num_tb;
        private System.Windows.Forms.TextBox denom_tb;
        private System.Windows.Forms.Label count_lbl;
    }
}

