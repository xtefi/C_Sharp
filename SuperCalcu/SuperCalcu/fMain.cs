using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperCalcu
{
    public partial class fMain : Form
    {
        private string _OperandoTxt;
        private string _Operator;
        private decimal _Operand;
        
        public fMain()
        {
            InitializeComponent();
        }

        private void SetOperandoTxt(string value)
        {
            if(value == "0" || value == "1" || value == "2" || value == "3" || value == "4" || value == "5"
                || value == "6" || value == "7" || value == "8" || value == "9")
            { 
                if(_OperandoTxt == "0")
                {
                    _OperandoTxt = "";
                }
                _OperandoTxt = _OperandoTxt + value;
                pantalla.Text = _OperandoTxt;
                
            }
            else if(value == "+" || value == "-" || value == "*" || value == "/")
            {
                _Operator = value;
                _Operand = decimal.Parse(_OperandoTxt);
                _OperandoTxt="";
            }
            else if(value == "," || value == ".")
            {
                if(_OperandoTxt.IndexOf(",") < 0)
                {
                    _OperandoTxt = _OperandoTxt + ",";
                    pantalla.Text = _OperandoTxt;
                }
            }
            else if(value == "\b")
            {
                Delete();
            }
            else if(value == "\u001b")
            {
                BorrarTodo();
            }
        }

        private void DoOperation()
        {
            decimal resultado = 0;
            if(_Operator == "+")
            {
                resultado = _Operand + decimal.Parse(_OperandoTxt);
            }
            else if (_Operator == "-")
            {
                resultado = _Operand - decimal.Parse(_OperandoTxt);
            }
            else if (_Operator == "*")
            {
                resultado = _Operand * decimal.Parse(_OperandoTxt);
            }
            else if (_Operator == "/")
            {
                resultado = _Operand / decimal.Parse(_OperandoTxt);
            }
            pantalla.Text = resultado.ToString();
        }

        private void BorrarTodo()
        {
            _OperandoTxt = "0";
            _Operand = 0;
            pantalla.Text = "0";
        }

        private void Delete()
        {
            if(_OperandoTxt.Length > 1)
            { 
                _OperandoTxt = _OperandoTxt.Substring(0, _OperandoTxt.Length - 1);
                pantalla.Text = _OperandoTxt;
            }
            else
            {
                _OperandoTxt = "0";
            }
        }

        private void buttonCero_Click(object sender, EventArgs e)
        {
            SetOperandoTxt("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetOperandoTxt("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetOperandoTxt("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetOperandoTxt("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetOperandoTxt("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetOperandoTxt("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SetOperandoTxt("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SetOperandoTxt("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SetOperandoTxt("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SetOperandoTxt("9");
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            SetOperandoTxt("+");
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            SetOperandoTxt("-");
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            SetOperandoTxt("/");
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            SetOperandoTxt("*");
        }

        private void fMain_KeyPress(object sender, KeyPressEventArgs e)
        {
           SetOperandoTxt(e.KeyChar.ToString());
        }

        private void equal_Click(object sender, EventArgs e)
        {
            DoOperation();
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BorrarTodo();
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            SetOperandoTxt(",");
        }
    }
}
