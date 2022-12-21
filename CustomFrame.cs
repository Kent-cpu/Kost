

namespace Prog_lab1_2
{
    internal class CustomFrame
    {
        public string symbol { get; set; }
        public CustomFrame() {}

        public void print(System.Windows.Forms.Label topBorder, System.Windows.Forms.Label bottomBorder, 
            System.Windows.Forms.Label leftBorder, System.Windows.Forms.Label rightBorder)
        {
            topBorder.Text = "";
            bottomBorder.Text = "";
            leftBorder.Text = "";
            rightBorder.Text = "";
            for (int i = 0; i < topBorder.Size.Width; i++)
            {
                topBorder.Text += this.symbol;
                bottomBorder.Text += this.symbol;
            }

            for(int i = 0; i < leftBorder.Size.Height; i++)
            {
                leftBorder.Text += this.symbol;
                rightBorder.Text += this.symbol;
            }
        }
    }
}