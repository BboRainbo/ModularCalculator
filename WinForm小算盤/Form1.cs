namespace WinForm小算盤
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void NumberInput_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender; // 取得觸發這個事件的按鈕
            if (Operator == null)       //根據是否有輸入過運算元來判斷
            { Num1Box.Text += btn.Text; }// 把按鈕上的文字加到輸入欄位1中
            else
            { Num2Box.Text += btn.Text; } // 把按鈕上的文字加到輸入欄位2中
        }
        private void HistoryTraceBack_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            num1 = Num1Box.Text;
            OperatorBox.Text = btn.Text;
            Operator = btn.Text;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            num1 = Num1Box.Text;
            OperatorBox.Text = btn.Text;
            Operator = btn.Text;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            num2 = Num2Box.Text;
            double result = Calculator.Calculate(num1, Operator, num2);
            ResultBox.Text = result.ToString();
            num1 = result.ToString();
            Num1Box.Text = num1;
            num2 = null;
            Operator = null;
            OperatorBox.Clear();
            Num2Box.Clear();
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            num1 = null;
            num2 = null;
            Operator = null;
            OperatorBox.Clear();
            Num1Box.Clear();
            Num2Box.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        //private void CurrentInputBox(object sender, EventArgs e)
        //{

        //}
    }
}
