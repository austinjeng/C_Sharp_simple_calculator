
namespace C_Sharp_simple_calculator
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
            this.testBoxResult = new System.Windows.Forms.TextBox();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Buttton7 = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.ButtonMultiple = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.ButtonModel = new System.Windows.Forms.Button();
            this.ButtonCE = new System.Windows.Forms.Button();
            this.ButtonEqual = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.ButtonDecimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testBoxResult
            // 
            this.testBoxResult.Location = new System.Drawing.Point(13, 12);
            this.testBoxResult.Name = "testBoxResult";
            this.testBoxResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.testBoxResult.Size = new System.Drawing.Size(218, 22);
            this.testBoxResult.TabIndex = 0;
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Location = new System.Drawing.Point(13, 40);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(50, 50);
            this.ButtonPlus.TabIndex = 1;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(13, 96);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(50, 50);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(13, 152);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(50, 50);
            this.Button4.TabIndex = 3;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Buttton7
            // 
            this.Buttton7.Location = new System.Drawing.Point(13, 208);
            this.Buttton7.Name = "Buttton7";
            this.Buttton7.Size = new System.Drawing.Size(50, 50);
            this.Buttton7.TabIndex = 4;
            this.Buttton7.Text = "7";
            this.Buttton7.UseVisualStyleBackColor = true;
            this.Buttton7.Click += new System.EventHandler(this.Buttton7_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.Location = new System.Drawing.Point(69, 40);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(50, 50);
            this.ButtonMinus.TabIndex = 5;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = true;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(69, 96);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(50, 50);
            this.Button2.TabIndex = 6;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(69, 152);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(50, 50);
            this.Button5.TabIndex = 7;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button8
            // 
            this.Button8.Location = new System.Drawing.Point(69, 208);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(50, 50);
            this.Button8.TabIndex = 8;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // ButtonMultiple
            // 
            this.ButtonMultiple.Location = new System.Drawing.Point(125, 40);
            this.ButtonMultiple.Name = "ButtonMultiple";
            this.ButtonMultiple.Size = new System.Drawing.Size(50, 50);
            this.ButtonMultiple.TabIndex = 9;
            this.ButtonMultiple.Text = "*";
            this.ButtonMultiple.UseVisualStyleBackColor = true;
            this.ButtonMultiple.Click += new System.EventHandler(this.ButtonMultiple_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(125, 96);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(50, 50);
            this.Button3.TabIndex = 10;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(125, 152);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(50, 50);
            this.Button6.TabIndex = 11;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button9
            // 
            this.Button9.Location = new System.Drawing.Point(125, 208);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(50, 50);
            this.Button9.TabIndex = 12;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.Location = new System.Drawing.Point(181, 40);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(50, 50);
            this.ButtonDivide.TabIndex = 13;
            this.ButtonDivide.Text = "/";
            this.ButtonDivide.UseVisualStyleBackColor = true;
            this.ButtonDivide.Click += new System.EventHandler(this.ButtonDivide_Click);
            // 
            // ButtonModel
            // 
            this.ButtonModel.Location = new System.Drawing.Point(181, 96);
            this.ButtonModel.Name = "ButtonModel";
            this.ButtonModel.Size = new System.Drawing.Size(50, 50);
            this.ButtonModel.TabIndex = 14;
            this.ButtonModel.Text = "%";
            this.ButtonModel.UseVisualStyleBackColor = true;
            this.ButtonModel.Click += new System.EventHandler(this.ButtonModel_Click);
            // 
            // ButtonCE
            // 
            this.ButtonCE.Location = new System.Drawing.Point(181, 152);
            this.ButtonCE.Name = "ButtonCE";
            this.ButtonCE.Size = new System.Drawing.Size(50, 50);
            this.ButtonCE.TabIndex = 15;
            this.ButtonCE.Text = "CE";
            this.ButtonCE.UseVisualStyleBackColor = true;
            this.ButtonCE.Click += new System.EventHandler(this.ButtonCE_Click);
            // 
            // ButtonEqual
            // 
            this.ButtonEqual.Location = new System.Drawing.Point(181, 208);
            this.ButtonEqual.Name = "ButtonEqual";
            this.ButtonEqual.Size = new System.Drawing.Size(50, 106);
            this.ButtonEqual.TabIndex = 16;
            this.ButtonEqual.Text = "=";
            this.ButtonEqual.UseVisualStyleBackColor = true;
            this.ButtonEqual.Click += new System.EventHandler(this.ButtonEqual_Click);
            // 
            // Button0
            // 
            this.Button0.Location = new System.Drawing.Point(69, 264);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(50, 50);
            this.Button0.TabIndex = 17;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = true;
            this.Button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // ButtonDecimal
            // 
            this.ButtonDecimal.Location = new System.Drawing.Point(125, 264);
            this.ButtonDecimal.Name = "ButtonDecimal";
            this.ButtonDecimal.Size = new System.Drawing.Size(50, 50);
            this.ButtonDecimal.TabIndex = 18;
            this.ButtonDecimal.Text = ".";
            this.ButtonDecimal.UseVisualStyleBackColor = true;
            this.ButtonDecimal.Click += new System.EventHandler(this.ButtonDecimal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 324);
            this.Controls.Add(this.ButtonDecimal);
            this.Controls.Add(this.Button0);
            this.Controls.Add(this.ButtonEqual);
            this.Controls.Add(this.ButtonCE);
            this.Controls.Add(this.ButtonModel);
            this.Controls.Add(this.ButtonDivide);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.ButtonMultiple);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.ButtonMinus);
            this.Controls.Add(this.Buttton7);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.ButtonPlus);
            this.Controls.Add(this.testBoxResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "計算機";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox testBoxResult;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Buttton7;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button ButtonMultiple;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button ButtonDivide;
        private System.Windows.Forms.Button ButtonModel;
        private System.Windows.Forms.Button ButtonCE;
        private System.Windows.Forms.Button ButtonEqual;
        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.Button ButtonDecimal;
    }
}

