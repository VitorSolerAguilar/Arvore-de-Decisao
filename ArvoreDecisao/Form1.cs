namespace ArvoreDecisao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Resultado_Click(object sender, EventArgs e)
        {
            float filho1 = float.Parse(txbFilho1.Text);
            float filho2 = float.Parse(txbFilho2.Text);
            float filho3 = float.Parse(txbFilho3.Text);
            float filho4 = float.Parse(txbFilho4.Text);

            float folha1 = float.Parse(txbFolha1.Text);
            float folha2 = float.Parse(txbFolha2.Text);
            float folha3 = float.Parse(txbFolha3.Text);
            float folha4 = float.Parse(txbFolha4.Text);
            float folha5 = float.Parse(txbFolha5.Text);
            float folha6 = float.Parse(txbFolha6.Text);
            float folha7 = float.Parse(txbFolha7.Text);
            float folha8 = float.Parse(txbFolha8.Text);

            float investimento1 = float.Parse(txbInvestimento1.Text);
            float investimento2 = float.Parse(txbInvestimento2.Text);
            float investimento3 = float.Parse(txbInvestimento3.Text);
            float investimento4 = float.Parse(txbInvestimento4.Text);
            float investimento5 = float.Parse(txbInvestimento5.Text);
            float investimento6 = float.Parse(txbInvestimento6.Text);
            float investimento7 = float.Parse(txbInvestimento7.Text);
            float investimento8 = float.Parse(txbInvestimento8.Text);

            //Resultado da Opção 1
            float receitaOpcao1 = (investimento1 * (folha1 / 100));
            float receitaOpcao2 = (investimento2 * (folha2 / 100));
            float totalReceita1 = (receitaOpcao1 + receitaOpcao2) - filho1;

            lblReceitaOp1.Text = receitaOpcao1.ToString("C2");
            lblReceitaOp2.Text = receitaOpcao2.ToString("C2");
            lblReceitaEsperada.Text = totalReceita1.ToString("C2");

            //Resultado da Opção 2
            float receitaOpcao3 = (investimento3 * (folha3 / 100));
            float receitaOpcao4 = (investimento4 * (folha4 / 100));
            float totalReceita2 = (receitaOpcao3 + receitaOpcao4) - filho2;

            lblReceitaOp3.Text = receitaOpcao3.ToString("C2");
            lblReceitaOp4.Text = receitaOpcao4.ToString("C2");
            lblReceitaEsperada2.Text = totalReceita2.ToString("C2");

            //Resultado da Opção 3
            float receitaOpcao5 = (investimento5 * (folha5 / 100));
            float receitaOpcao6 = (investimento6 * (folha6 / 100));
            float totalReceita3 = (receitaOpcao5 + receitaOpcao6) - filho3;

            lblReceitaOp5.Text = receitaOpcao5.ToString("C2");
            lblReceitaOp6.Text = receitaOpcao6.ToString("C2");
            lblReceitaEsperada3.Text = totalReceita3.ToString("C2");

            //Resultado da Opção 4
            float receitaOpcao7 = (investimento7 * (folha7 / 100));
            float receitaOpcao8 = (investimento8 * (folha8 / 100));
            float totalReceita4 = (receitaOpcao7 + receitaOpcao8) - filho4;

            lblReceitaOp7.Text = receitaOpcao7.ToString("C2");
            lblReceitaOp8.Text = receitaOpcao8.ToString("C2");
            lblReceitaEsperada4.Text = totalReceita4.ToString("C2");
        }
    }
}
