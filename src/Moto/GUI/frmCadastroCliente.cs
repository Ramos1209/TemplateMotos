using Moto.Models;
using System;
using System.Windows.Forms;

namespace Moto.GUI
{
    public partial class FrmCadastroCliente : Form
    {
         Cliente _cliente;
        public FrmCadastroCliente(Cliente cliente)
        {
            InitializeComponent();
            this._cliente = cliente;
           
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            try
            {
               
                _cliente.DataCadastro = DateTime.Now;
                txtId.DataBindings.Add(new Binding("Text",_cliente,"Id",false));
                txtApelido.DataBindings.Add(new Binding("Text", _cliente, "Apelido"));
                txtNome.DataBindings.Add(new Binding("Text", _cliente, "Nome"));
                txtEmail.DataBindings.Add(new Binding("Text", _cliente, "Email"));
                txtEnd.DataBindings.Add(new Binding("Text", _cliente, "Endereco"));
                txtCep.DataBindings.Add(new Binding("Text", _cliente, "Cep"));
                txtTel1.DataBindings.Add(new Binding("Text", _cliente, "Telefone1"));
                txtTel2.DataBindings.Add(new Binding("Text", _cliente, "Telefone2"));
                txtCelular.DataBindings.Add(new Binding("Text", _cliente, "Celular"));
                txtComplemento.DataBindings.Add(new Binding("Text", _cliente, "Complemento"));
                txtContato.DataBindings.Add(new Binding("Text", _cliente, "Contato"));
                txtUF.DataBindings.Add(new Binding("Text", _cliente, "UF"));
                txtBairro.DataBindings.Add(new Binding("Text", _cliente, "Bairro"));
                txtCidade.DataBindings.Add(new Binding("Text", _cliente, "Cidade"));
                txtData.DataBindings.Add(new Binding("Text", _cliente, "DataCadastro"));
              
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
         

        }

        private static void LimparTextBoxs(Control.ControlCollection controles)
        {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control ctrl in controles)
            {
                //Se o contorle for um TextBox...
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
            }
        }


    }
}
