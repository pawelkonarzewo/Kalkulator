using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string RpnCiag;
        //char RodzajDzialania;
        //string znakidziałania;

        private void TBerkan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bBsqrt_Click(object sender, EventArgs e)
        {
            Dzialanie(" SQTR ");
        }

        private void Bpotega_Click(object sender, EventArgs e)
        {
            Dzialanie(" POTEGA ");
        }

        private void Bmod_Click(object sender, EventArgs e)
        {
            Dzialanie(" MOD ");
        }

        private void Bdata_Click(object sender, EventArgs e)
        {
           //Dzialanie(" DATA ");
        }

        private void Bczas_Click(object sender, EventArgs e)
        {
            //Dzialanie(" CZAS ");
        }

        private void Bspace_Click(object sender, EventArgs e)
        {
            Dzialanie(" ");
        }

        private void Bdodawanie_Click(object sender, EventArgs e)
        {
            Dzialanie(" + ");
        }

        private void Bodejmowanie_Click(object sender, EventArgs e)
        {
            Dzialanie(" - ");
        }

        private void Bmnozenie_Click(object sender, EventArgs e)
        {
            Dzialanie(" * ");
        }

        private void Bdzielenie_Click(object sender, EventArgs e)
        {
            Dzialanie(" / ");
        }

        private void B9_Click(object sender, EventArgs e)
        {
            Dzialanie("9");
        }

        private void B8_Click(object sender, EventArgs e)
        {
            Dzialanie("8");
        }

        private void B7_Click(object sender, EventArgs e)
        {
            Dzialanie("7");
        }

        private void B4_Click(object sender, EventArgs e)
        {
            Dzialanie("4");
        }

        private void B5_Click(object sender, EventArgs e)
        {
            Dzialanie("5");
        }

        private void B6_Click(object sender, EventArgs e)
        {
            Dzialanie("6");
        }

        private void B3_Click(object sender, EventArgs e)
        {
            Dzialanie("3");
        }

        private void B2_Click(object sender, EventArgs e)
        {
            Dzialanie("2");
        }

        private void B1_Click(object sender, EventArgs e)
        {
            Dzialanie("1");
        }

        private void Bzmianaznaku_Click(object sender, EventArgs e)
        {
            Dzialanie("-");
        }

        private void Bkropka_Click(object sender, EventArgs e)
        {
            Dzialanie(",");
        }

        private void Bzero_Click(object sender, EventArgs e)
        {
            Dzialanie("0");
        }

        private void Bclear_Click(object sender, EventArgs e)
        {
           RpnCiag = "";
            Dzialanie("");
        }

        private void Dzialanie(string liczba)
        {
            RpnCiag += liczba;
            TBerkan.Text = RpnCiag;
        }

        private void Bwynik_Click(object sender, EventArgs e)
        {
            string[] rpnTokens = RpnCiag.Split(' ');
            Stack<double> stack = new Stack<double>();
            double number1;
       //     DateTime date;
       //     DateTime date2;
            try
            {
                foreach (string token in rpnTokens)
                {
                    if (double.TryParse(token, out number1))
                    {
                        stack.Push(number1);
                    }
                    else
                    {
                        switch (token)
                        {
                            case "+":
                                {
                                    stack.Push(stack.Pop() + stack.Pop());
                                    break;
                                }
                            case "-":
                                {
                                    number1 = stack.Pop();
                                    stack.Push(stack.Pop() - number1);
                                    break;
                                }
                            case "*":
                                {
                                    stack.Push(stack.Pop() * stack.Pop());
                                    break;
                                }
                            case "/":
                                {
                                    number1 = stack.Pop();
                                    stack.Push(stack.Pop() / number1);
                                    break;
                                }
                            case "POTEGA":
                                {
                                    number1 = stack.Pop();
                                    stack.Push(Math.Pow(stack.Pop(), number1));
                                    break;
                                }
                            case "SQTR":
                                {
                                    stack.Push(Math.Sqrt(stack.Pop()));
                                    break;
                                }
                            case "MOD":
                                {
                                    number1 = stack.Pop();
                                    stack.Push(stack.Pop() % number1);
                                    break;
                                }
                    /*        case "DATA":
                                {
                                    number1 = stack.Pop();
                                    date = Convert.ToDateTime(number1);
                                    number1 = stack.Pop();
                                    date2 = Convert.ToDateTime(number1);
                                    TimeSpan timeSpan = date - date2;
                                    number1 = Convert.ToDouble(timeSpan);
                                    stack.Push(number1);
                                    break;
                                    
                                }  */
                            default:
                                RpnCiag = "Error in Kalkulator RNP";
                                break;
                        }
                    }
                }


                number1 = stack.Pop();
                RpnCiag = Convert.ToString(number1);
                TBerkan.Text = RpnCiag;
            }
            catch
            {
                RpnCiag = "Błąd w wyrażeniu";
                TBerkan.Text = RpnCiag;
            }

        }

        private void TBekran2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBekran2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                    {
                        Dzialanie("0");
                        break;
                    }
                case Keys.D1:
                    {
                        Dzialanie("1");
                        break;
                    }
                case Keys.D2:
                    {
                        Dzialanie("2");
                        break;
                    }
                case Keys.D3:
                    {
                        Dzialanie("3");
                        break;
                    }
                case Keys.D4:
                    {
                        Dzialanie("4");
                        break;
                    }
                case Keys.D5:
                    {
                        Dzialanie("5");
                        break;
                    }
                case Keys.D6:
                    {
                        Dzialanie("6");
                        break;
                    }
                case Keys.D7:
                    {
                        Dzialanie("7");
                        break;
                    }
                case Keys.D8:
                    {
                        Dzialanie("8");
                        break;
                    }
                case Keys.D9:
                    {
                        Dzialanie("9");
                        break;
                    }
                case Keys.Add:
                    {
                        Dzialanie(" + ");
                        break;
                    }
                case Keys.Subtract:
                    {
                        Dzialanie(" - ");
                        break;
                    }
                case Keys.Multiply:
                    {
                        Dzialanie(" * ");
                        break;
                    }
                case Keys.Divide:
                    {
                        Dzialanie(" / ");
                        break;
                    }
                case Keys.Space:
                    {
                        Dzialanie(" ");
                        break;
                    }
                case Keys.Oemcomma:
                    {
                        Dzialanie(",");
                        break;
                    }
                case Keys.OemPeriod:
                    {
                        Dzialanie(",");
                        break;
                    }
                case Keys.M:
                    {
                        Dzialanie(" MOD ");
                        break;
                    }
                case Keys.P:
                    {
                        Dzialanie(" POTEGAf ");
                        break;
                    }
                case Keys.S:
                    {
                        Dzialanie(" SQRT ");
                        break;
                    }
            }

        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
