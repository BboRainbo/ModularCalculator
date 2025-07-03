using System;

namespace WinForm小算盤
{


    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private string num1=null;
        private string num2=null;
        private string Operator=null;
        private string result = null;

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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            Num1Box = new TextBox();
            ResultBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            OperatorBox = new TextBox();
            Num2Box = new TextBox();
            button17 = new Button();
            HistoryBox1 = new TextBox();
            HistoryBox2 = new TextBox();
            HistoryBox3 = new TextBox();
            HistoryBox4 = new TextBox();
            HistoryBox5 = new TextBox();
            button_history1 = new Button();
            button_history2 = new Button();
            button_history3 = new Button();
            button_history5 = new Button();
            button_history4 = new Button();
            label3 = new Label();
            label5 = new Label();
            PrefixBox = new TextBox();
            PostFixBox = new TextBox();
            button18 = new Button();
            button19 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(14, 159);
            button1.Name = "button1";
            button1.Size = new Size(118, 67);
            button1.TabIndex = 0;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Equal_Click;
            // 
            // button2
            // 
            button2.Location = new Point(13, 232);
            button2.Name = "button2";
            button2.Size = new Size(119, 62);
            button2.TabIndex = 1;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Operator_Click;
            // 
            // button3
            // 
            button3.Location = new Point(14, 300);
            button3.Name = "button3";
            button3.Size = new Size(118, 62);
            button3.TabIndex = 2;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Operator_Click;
            // 
            // button4
            // 
            button4.Location = new Point(14, 368);
            button4.Name = "button4";
            button4.Size = new Size(118, 62);
            button4.TabIndex = 3;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Operator_Click;
            // 
            // button5
            // 
            button5.Location = new Point(14, 436);
            button5.Name = "button5";
            button5.Size = new Size(118, 56);
            button5.TabIndex = 4;
            button5.Text = "/";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Operator_Click;
            // 
            // Num1Box
            // 
            Num1Box.Location = new Point(14, 36);
            Num1Box.Name = "Num1Box";
            Num1Box.Size = new Size(140, 35);
            Num1Box.TabIndex = 5;
            Num1Box.TextChanged += textBox1_TextChanged;
            // 
            // ResultBox
            // 
            ResultBox.Location = new Point(14, 109);
            ResultBox.Name = "ResultBox";
            ResultBox.Size = new Size(337, 35);
            ResultBox.TabIndex = 6;
            ResultBox.TextChanged += ResultBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 5);
            label1.Name = "label1";
            label1.Size = new Size(56, 28);
            label1.TabIndex = 7;
            label1.Text = "算式";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 78);
            label2.Name = "label2";
            label2.Size = new Size(56, 28);
            label2.TabIndex = 8;
            label2.Text = "答案";
            // 
            // button6
            // 
            button6.Location = new Point(138, 159);
            button6.Name = "button6";
            button6.Size = new Size(140, 67);
            button6.TabIndex = 9;
            button6.Text = "Clear";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Clear_Click;
            // 
            // button7
            // 
            button7.Location = new Point(138, 232);
            button7.Name = "button7";
            button7.Size = new Size(67, 62);
            button7.TabIndex = 10;
            button7.Text = "1";
            button7.UseVisualStyleBackColor = true;
            button7.Click += NumberInput_Click;
            // 
            // button8
            // 
            button8.Location = new Point(138, 300);
            button8.Name = "button8";
            button8.Size = new Size(67, 62);
            button8.TabIndex = 11;
            button8.Text = "4";
            button8.UseVisualStyleBackColor = true;
            button8.Click += NumberInput_Click;
            // 
            // button9
            // 
            button9.Location = new Point(138, 368);
            button9.Name = "button9";
            button9.Size = new Size(67, 62);
            button9.TabIndex = 12;
            button9.Text = "7";
            button9.UseVisualStyleBackColor = true;
            button9.Click += NumberInput_Click;
            // 
            // button10
            // 
            button10.Location = new Point(211, 232);
            button10.Name = "button10";
            button10.Size = new Size(67, 62);
            button10.TabIndex = 13;
            button10.Text = "2";
            button10.UseVisualStyleBackColor = true;
            button10.Click += NumberInput_Click;
            // 
            // button11
            // 
            button11.Location = new Point(211, 300);
            button11.Name = "button11";
            button11.Size = new Size(67, 62);
            button11.TabIndex = 14;
            button11.Text = "5";
            button11.UseVisualStyleBackColor = true;
            button11.Click += NumberInput_Click;
            // 
            // button12
            // 
            button12.Location = new Point(211, 368);
            button12.Name = "button12";
            button12.Size = new Size(67, 62);
            button12.TabIndex = 15;
            button12.Text = "8";
            button12.UseVisualStyleBackColor = true;
            button12.Click += NumberInput_Click;
            // 
            // button13
            // 
            button13.Location = new Point(284, 232);
            button13.Name = "button13";
            button13.Size = new Size(67, 62);
            button13.TabIndex = 16;
            button13.Text = "3";
            button13.UseVisualStyleBackColor = true;
            button13.Click += NumberInput_Click;
            // 
            // button14
            // 
            button14.Location = new Point(284, 300);
            button14.Name = "button14";
            button14.Size = new Size(67, 62);
            button14.TabIndex = 17;
            button14.Text = "6";
            button14.UseVisualStyleBackColor = true;
            button14.Click += NumberInput_Click;
            // 
            // button15
            // 
            button15.Location = new Point(284, 368);
            button15.Name = "button15";
            button15.Size = new Size(67, 62);
            button15.TabIndex = 18;
            button15.Text = "9";
            button15.UseVisualStyleBackColor = true;
            button15.Click += NumberInput_Click;
            // 
            // button16
            // 
            button16.Location = new Point(138, 436);
            button16.Name = "button16";
            button16.Size = new Size(67, 62);
            button16.TabIndex = 19;
            button16.Text = ".";
            button16.UseVisualStyleBackColor = true;
            button16.Click += NumberInput_Click;
            // 
            // OperatorBox
            // 
            OperatorBox.Location = new Point(160, 36);
            OperatorBox.Name = "OperatorBox";
            OperatorBox.Size = new Size(45, 35);
            OperatorBox.TabIndex = 20;
            // 
            // Num2Box
            // 
            Num2Box.Location = new Point(211, 36);
            Num2Box.Name = "Num2Box";
            Num2Box.Size = new Size(140, 35);
            Num2Box.TabIndex = 21;
            // 
            // button17
            // 
            button17.Location = new Point(284, 436);
            button17.Name = "button17";
            button17.Size = new Size(67, 62);
            button17.TabIndex = 22;
            button17.Text = "=";
            button17.UseVisualStyleBackColor = true;
            button17.Click += Equal_Click;
            // 
            // HistoryBox1
            // 
            HistoryBox1.Location = new Point(381, 230);
            HistoryBox1.Name = "HistoryBox1";
            HistoryBox1.Size = new Size(260, 35);
            HistoryBox1.TabIndex = 23;
            // 
            // HistoryBox2
            // 
            HistoryBox2.Location = new Point(381, 272);
            HistoryBox2.Name = "HistoryBox2";
            HistoryBox2.Size = new Size(260, 35);
            HistoryBox2.TabIndex = 25;
            // 
            // HistoryBox3
            // 
            HistoryBox3.Location = new Point(381, 313);
            HistoryBox3.Name = "HistoryBox3";
            HistoryBox3.Size = new Size(260, 35);
            HistoryBox3.TabIndex = 27;
            // 
            // HistoryBox4
            // 
            HistoryBox4.Location = new Point(381, 354);
            HistoryBox4.Name = "HistoryBox4";
            HistoryBox4.Size = new Size(260, 35);
            HistoryBox4.TabIndex = 29;
            // 
            // HistoryBox5
            // 
            HistoryBox5.Location = new Point(381, 395);
            HistoryBox5.Name = "HistoryBox5";
            HistoryBox5.Size = new Size(260, 35);
            HistoryBox5.TabIndex = 30;
            // 
            // button_history1
            // 
            button_history1.Location = new Point(647, 231);
            button_history1.Name = "button_history1";
            button_history1.Size = new Size(166, 34);
            button_history1.TabIndex = 31;
            button_history1.Text = "Goto History";
            button_history1.UseVisualStyleBackColor = true;
            button_history1.Click += HistoryTraceBack_Click;
            // 
            // button_history2
            // 
            button_history2.Location = new Point(647, 272);
            button_history2.Name = "button_history2";
            button_history2.Size = new Size(166, 34);
            button_history2.TabIndex = 32;
            button_history2.Text = "Goto History";
            button_history2.UseVisualStyleBackColor = true;
            button_history2.Click += HistoryTraceBack_Click;
            // 
            // button_history3
            // 
            button_history3.Location = new Point(647, 313);
            button_history3.Name = "button_history3";
            button_history3.Size = new Size(166, 34);
            button_history3.TabIndex = 33;
            button_history3.Text = "Goto History";
            button_history3.UseVisualStyleBackColor = true;
            button_history3.Click += HistoryTraceBack_Click;
            // 
            // button_history5
            // 
            button_history5.Location = new Point(647, 396);
            button_history5.Name = "button_history5";
            button_history5.Size = new Size(166, 34);
            button_history5.TabIndex = 34;
            button_history5.Text = "Goto History";
            button_history5.UseVisualStyleBackColor = true;
            button_history5.Click += HistoryTraceBack_Click;
            // 
            // button_history4
            // 
            button_history4.Location = new Point(647, 355);
            button_history4.Name = "button_history4";
            button_history4.Size = new Size(166, 34);
            button_history4.TabIndex = 35;
            button_history4.Text = "Goto History";
            button_history4.UseVisualStyleBackColor = true;
            button_history4.Click += HistoryTraceBack_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(389, 68);
            label3.Name = "label3";
            label3.Size = new Size(69, 28);
            label3.TabIndex = 36;
            label3.Text = "Prefix";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(377, 109);
            label5.Name = "label5";
            label5.Size = new Size(81, 28);
            label5.TabIndex = 38;
            label5.Text = "Postfix";
            // 
            // PrefixBox
            // 
            PrefixBox.Location = new Point(490, 68);
            PrefixBox.Name = "PrefixBox";
            PrefixBox.Size = new Size(222, 35);
            PrefixBox.TabIndex = 39;
            // 
            // PostFixBox
            // 
            PostFixBox.Location = new Point(490, 109);
            PostFixBox.Name = "PostFixBox";
            PostFixBox.Size = new Size(222, 35);
            PostFixBox.TabIndex = 41;
            // 
            // button18
            // 
            button18.Location = new Point(547, 28);
            button18.Name = "button18";
            button18.Size = new Size(112, 34);
            button18.TabIndex = 42;
            button18.Text = "Transfer";
            button18.UseVisualStyleBackColor = true;
            button18.Click += FixChange_Click;
            // 
            // button19
            // 
            button19.Location = new Point(211, 436);
            button19.Name = "button19";
            button19.Size = new Size(67, 62);
            button19.TabIndex = 43;
            button19.Text = "0";
            button19.UseVisualStyleBackColor = true;
            button19.Click += NumberInput_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 501);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(PostFixBox);
            Controls.Add(PrefixBox);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(button_history4);
            Controls.Add(button_history5);
            Controls.Add(button_history3);
            Controls.Add(button_history2);
            Controls.Add(button_history1);
            Controls.Add(HistoryBox5);
            Controls.Add(HistoryBox4);
            Controls.Add(HistoryBox3);
            Controls.Add(HistoryBox2);
            Controls.Add(HistoryBox1);
            Controls.Add(button17);
            Controls.Add(Num2Box);
            Controls.Add(OperatorBox);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ResultBox);
            Controls.Add(Num1Box);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox Num1Box;
        private TextBox ResultBox;
        private Label label1;
        private Label label2;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private TextBox OperatorBox;
        private TextBox Num2Box;
        private TextBox CurrentInputBox;
        private Button button17;
        private TextBox HistoryBox1;
        private TextBox HistoryBox2;
        private TextBox HistoryBox3;
        private TextBox HistoryBox4;
        private TextBox HistoryBox5;
        private Button button_history1;
        private Button button_history2;
        private Button button_history3;
        private Button button_history5;
        private Button button_history4;
        private Label label3;
        private Label label5;
        private TextBox PrefixBox;
        private TextBox PostFixBox;
        private Button button18;
        private Button button19;
    }
}
