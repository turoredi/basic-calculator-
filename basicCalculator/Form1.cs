namespace basicCalculator
{
    public partial class Form1 : Form
    {
        public event Action<int> OnDigitPressed;
        public event Action<string> OnOperatorPressed;
        public event Action OnEqualsPressed;
        public event Action OnClearPressed;

        public Form1()
        {
            InitializeComponent();
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            button0.Click += (sender, e) => OnDigitPressed?.Invoke(0);
            button1.Click += (sender, e) => OnDigitPressed?.Invoke(1);
            button2.Click += (sender, e) => OnDigitPressed?.Invoke(2);
            button3.Click += (sender, e) => OnDigitPressed?.Invoke(3);
            button4.Click += (sender, e) => OnDigitPressed?.Invoke(4);
            button5.Click += (sender, e) => OnDigitPressed?.Invoke(5);
            button6.Click += (sender, e) => OnDigitPressed?.Invoke(6);
            button7.Click += (sender, e) => OnDigitPressed?.Invoke(7);
            button8.Click += (sender, e) => OnDigitPressed?.Invoke(8);
            button9.Click += (sender, e) => OnDigitPressed?.Invoke(9);
            buttonAdd.Click += (sender, e) => OnOperatorPressed?.Invoke("+");
            buttonSubtract.Click += (sender, e) => OnOperatorPressed?.Invoke("-");
            buttonMultiply.Click += (sender, e) => OnOperatorPressed?.Invoke("*");
            buttonDivide.Click += (sender, e) => OnOperatorPressed?.Invoke("/");
            buttonEquals.Click += (sender, e) => OnEqualsPressed?.Invoke();
            buttonClear.Click += (sender, e) => OnClearPressed?.Invoke();
        }

        public void UpdateDisplay(string value)
        {
            textBoxDisplay.Text = value;
        }
    }

}
