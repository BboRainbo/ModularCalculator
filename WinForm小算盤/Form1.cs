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
            if (OperatorBox.Text == "")       //根據是否有輸入過運算元來判斷
            { Num1Box.Text += btn.Text; }// 把按鈕上的文字加到輸入欄位1中
            else
            { Num2Box.Text += btn.Text; } // 把按鈕上的文字加到輸入欄位2中
        }
        private void HistoryTraceBack_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string btn_name = btn.Name;
            //用btn的名字來決定調用哪一筆 history，必須這裡是取名稱的最後一位數
            //但會有以下錯誤在 10個以上按鈕時發生 button21 與 button 都會調用到 history"1"

            int index = int.Parse((btn_name[btn_name.Length - 1]).ToString()) - 1;
            var history = History.History.Read(index);
            Num1Box.Text = history[0];
            OperatorBox.Text = history[1];
            Num2Box.Text = history[2];
            ResultBox.Text = history[3];
        }
        private void HistoryUpdate()
        {
            HistoryBox1.Text = History.History.Show(0);
            HistoryBox2.Text = History.History.Show(1);
            HistoryBox3.Text = History.History.Show(2);
            HistoryBox4.Text = History.History.Show(3);
            HistoryBox5.Text = History.History.Show(4);
            return;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (ResultBox.Text != "")
            {
                Num1Box.Text = ResultBox.Text;
                OperatorBox.Text = btn.Text;
            }
            OperatorBox.Text = btn.Text;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            double result = Calculator.Calculate(Num1Box.Text, OperatorBox.Text, Num2Box.Text);
            ResultBox.Text = result.ToString();
            History.History.Add(Num1Box.Text, OperatorBox.Text, Num2Box.Text, ResultBox.Text);
            HistoryUpdate();
            OperatorBox.Clear();
            Num2Box.Clear();
        }


        private void Clear_Click(object sender, EventArgs e)
        {
            OperatorBox.Clear();
            Num1Box.Clear();
            Num2Box.Clear();
            ResultBox.Clear();
        }
        private void FixChange_Click(object sender, EventArgs e)
        {
            string[] result = FixChange.ChangeFix.InfixToPrefix(Num1Box.Text, OperatorBox.Text, Num2Box.Text);
            string print = FixChange.ChangeFix.Print(result);
            PrefixBox.Text = print;
            result = FixChange.ChangeFix.InfixToPostfix(Num1Box.Text, OperatorBox.Text, Num2Box.Text);
            print = FixChange.ChangeFix.Print(result);
            PostFixBox.Text = print;            
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

        private void ResultBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }


        //private void CurrentInputBox(object sender, EventArgs e)
        //{

        //}
    }
}
