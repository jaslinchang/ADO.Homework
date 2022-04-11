
namespace ADO.Homework
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLotto = new System.Windows.Forms.Button();
            this.btn99 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.Step = new System.Windows.Forms.Label();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.btnFor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lab_Num = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btn1number = new System.Windows.Forms.Button();
            this.btn2Cc = new System.Windows.Forms.Button();
            this.btn2name = new System.Windows.Forms.Button();
            this.btn1find = new System.Windows.Forms.Button();
            this.btn1Min = new System.Windows.Forms.Button();
            this.btn1Max = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbOdd = new System.Windows.Forms.GroupBox();
            this.labAnswer = new System.Windows.Forms.Label();
            this.labResult = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbOdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLotto
            // 
            this.btnLotto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLotto.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLotto.Location = new System.Drawing.Point(306, 261);
            this.btnLotto.Name = "btnLotto";
            this.btnLotto.Size = new System.Drawing.Size(180, 34);
            this.btnLotto.TabIndex = 50;
            this.btnLotto.Text = "int[] 樂透 6個號碼不重複";
            this.btnLotto.UseVisualStyleBackColor = false;
            this.btnLotto.Click += new System.EventHandler(this.btnLotto_Click);
            // 
            // btn99
            // 
            this.btn99.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn99.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn99.Location = new System.Drawing.Point(37, 261);
            this.btn99.Name = "btn99";
            this.btn99.Size = new System.Drawing.Size(95, 34);
            this.btn99.TabIndex = 49;
            this.btn99.Text = "99乘法表";
            this.btn99.UseVisualStyleBackColor = false;
            this.btn99.Click += new System.EventHandler(this.btn99_Click);
            // 
            // btn100
            // 
            this.btn100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn100.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn100.Location = new System.Drawing.Point(165, 261);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(126, 34);
            this.btn100.TabIndex = 48;
            this.btn100.Text = "100的二進位是?";
            this.btn100.UseVisualStyleBackColor = false;
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnWhile);
            this.groupBox4.Controls.Add(this.btnDo);
            this.groupBox4.Controls.Add(this.Step);
            this.groupBox4.Controls.Add(this.txtStep);
            this.groupBox4.Controls.Add(this.btnFor);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtTo);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtFrom);
            this.groupBox4.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(264, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(222, 169);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "迴圈";
            // 
            // btnWhile
            // 
            this.btnWhile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnWhile.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWhile.Location = new System.Drawing.Point(147, 77);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(53, 25);
            this.btnWhile.TabIndex = 7;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = false;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDo
            // 
            this.btnDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDo.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDo.Location = new System.Drawing.Point(147, 118);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(53, 25);
            this.btnDo.TabIndex = 6;
            this.btnDo.Text = "Do";
            this.btnDo.UseVisualStyleBackColor = false;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // Step
            // 
            this.Step.AutoSize = true;
            this.Step.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Step.Location = new System.Drawing.Point(6, 118);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(40, 19);
            this.Step.TabIndex = 5;
            this.Step.Text = "Step";
            // 
            // txtStep
            // 
            this.txtStep.Location = new System.Drawing.Point(68, 115);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(67, 27);
            this.txtStep.TabIndex = 4;
            // 
            // btnFor
            // 
            this.btnFor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnFor.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFor.Location = new System.Drawing.Point(147, 37);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(53, 25);
            this.btnFor.TabIndex = 2;
            this.btnFor.Text = "For";
            this.btnFor.UseVisualStyleBackColor = false;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "TO :";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(68, 76);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(67, 27);
            this.txtTo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "From :";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(68, 37);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(67, 27);
            this.txtFrom.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(41, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 43);
            this.button1.TabIndex = 41;
            this.button1.Text = "三個數的最大值";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lab_Num
            // 
            this.lab_Num.AutoSize = true;
            this.lab_Num.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Num.Location = new System.Drawing.Point(37, 42);
            this.lab_Num.Name = "lab_Num";
            this.lab_Num.Size = new System.Drawing.Size(74, 19);
            this.lab_Num.TabIndex = 1;
            this.lab_Num.Text = "Number :";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(117, 39);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(67, 27);
            this.txt1.TabIndex = 0;
            // 
            // btn1number
            // 
            this.btn1number.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn1number.Location = new System.Drawing.Point(41, 80);
            this.btn1number.Name = "btn1number";
            this.btn1number.Size = new System.Drawing.Size(143, 43);
            this.btn1number.TabIndex = 2;
            this.btn1number.Text = "輸入的數字為\r\n奇數或偶數?";
            this.btn1number.UseVisualStyleBackColor = true;
            this.btn1number.Click += new System.EventHandler(this.btn1number_Click);
            // 
            // btn2Cc
            // 
            this.btn2Cc.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn2Cc.Location = new System.Drawing.Point(18, 148);
            this.btn2Cc.Name = "btn2Cc";
            this.btn2Cc.Size = new System.Drawing.Size(168, 44);
            this.btn2Cc.TabIndex = 6;
            this.btn2Cc.Text = "string[] 名字有 “C” or “c” 字樣有幾個 ";
            this.btn2Cc.UseVisualStyleBackColor = true;
            this.btn2Cc.Click += new System.EventHandler(this.btn2Cc_Click);
            // 
            // btn2name
            // 
            this.btn2name.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn2name.Location = new System.Drawing.Point(18, 104);
            this.btn2name.Name = "btn2name";
            this.btn2name.Size = new System.Drawing.Size(168, 33);
            this.btn2name.TabIndex = 5;
            this.btn2name.Text = "string[] 最長名字 ?";
            this.btn2name.UseVisualStyleBackColor = true;
            this.btn2name.Click += new System.EventHandler(this.btn2name_Click);
            // 
            // btn1find
            // 
            this.btn1find.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn1find.Location = new System.Drawing.Point(18, 42);
            this.btn1find.Name = "btn1find";
            this.btn1find.Size = new System.Drawing.Size(168, 47);
            this.btn1find.TabIndex = 5;
            this.btn1find.Text = "int[] 統計 奇數 有幾個 , 偶數有幾個";
            this.btn1find.UseVisualStyleBackColor = true;
            this.btn1find.Click += new System.EventHandler(this.btn1find_Click);
            // 
            // btn1Min
            // 
            this.btn1Min.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn1Min.Location = new System.Drawing.Point(27, 80);
            this.btn1Min.Name = "btn1Min";
            this.btn1Min.Size = new System.Drawing.Size(143, 33);
            this.btn1Min.TabIndex = 9;
            this.btn1Min.Text = " MAX()   / Min ( int[] )";
            this.btn1Min.UseVisualStyleBackColor = true;
            this.btn1Min.Click += new System.EventHandler(this.btn1Min_Click);
            // 
            // btn1Max
            // 
            this.btn1Max.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn1Max.Location = new System.Drawing.Point(27, 41);
            this.btn1Max.Name = "btn1Max";
            this.btn1Max.Size = new System.Drawing.Size(143, 33);
            this.btn1Max.TabIndex = 8;
            this.btn1Max.Text = "Max (params int[] )";
            this.btn1Max.UseVisualStyleBackColor = true;
            this.btn1Max.Click += new System.EventHandler(this.btn1Max_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn1Min);
            this.groupBox2.Controls.Add(this.btn1Max);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(757, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 144);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "陣列arr_Str[]";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(36, 337);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 32);
            this.btnClear.TabIndex = 45;
            this.btnClear.Text = "清空結果欄";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn2Cc);
            this.groupBox1.Controls.Add(this.btn2name);
            this.groupBox1.Controls.Add(this.btn1find);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(518, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 223);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "陣列arr[]";
            // 
            // grbOdd
            // 
            this.grbOdd.Controls.Add(this.button1);
            this.grbOdd.Controls.Add(this.lab_Num);
            this.grbOdd.Controls.Add(this.txt1);
            this.grbOdd.Controls.Add(this.btn1number);
            this.grbOdd.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grbOdd.Location = new System.Drawing.Point(33, 28);
            this.grbOdd.Name = "grbOdd";
            this.grbOdd.Size = new System.Drawing.Size(206, 212);
            this.grbOdd.TabIndex = 43;
            this.grbOdd.TabStop = false;
            this.grbOdd.Text = "判斷奇偶數";
            // 
            // labAnswer
            // 
            this.labAnswer.AutoSize = true;
            this.labAnswer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labAnswer.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAnswer.Location = new System.Drawing.Point(121, 388);
            this.labAnswer.Name = "labAnswer";
            this.labAnswer.Size = new System.Drawing.Size(41, 20);
            this.labAnswer.TabIndex = 42;
            this.labAnswer.Text = "結果";
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labResult.Location = new System.Drawing.Point(33, 383);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(82, 24);
            this.labResult.TabIndex = 41;
            this.labResult.Text = "Result : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 606);
            this.Controls.Add(this.btnLotto);
            this.Controls.Add(this.btn99);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbOdd);
            this.Controls.Add(this.labAnswer);
            this.Controls.Add(this.labResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grbOdd.ResumeLayout(false);
            this.grbOdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLotto;
        private System.Windows.Forms.Button btn99;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Label Step;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lab_Num;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btn1number;
        private System.Windows.Forms.Button btn2Cc;
        private System.Windows.Forms.Button btn2name;
        private System.Windows.Forms.Button btn1find;
        private System.Windows.Forms.Button btn1Min;
        private System.Windows.Forms.Button btn1Max;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbOdd;
        private System.Windows.Forms.Label labAnswer;
        private System.Windows.Forms.Label labResult;
    }
}

