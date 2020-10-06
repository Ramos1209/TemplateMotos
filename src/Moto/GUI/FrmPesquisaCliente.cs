using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moto.Models;

namespace Moto.GUI
{
    public partial class FrmPesquisaCliente :frmModeloGrid
    {
        public FrmPesquisaCliente()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (sender == btnAdd)
            {
                clienteBindingSource.Add(new Cliente());
                clienteBindingSource.MoveLast();
            }
            if(clienteBindingSource.Current == null) return;

            using (var cad = new FrmCadastroCliente(clienteBindingSource.Current as Cliente))
            {
                if (cad.ShowDialog() == DialogResult.OK)
                {
                    var cliente = clienteBindingSource.Current as Cliente;

                    if(cliente == null) return;
                    using (var db = new MotoContext())
                    {
                        if (db.Entry<Cliente>(cliente).State == EntityState.Detached)
                         db.Set<Cliente>().Attach(cliente);

                        db.Entry<Cliente>(cliente).State = cliente.Id == 0 ? EntityState.Added : EntityState.Modified;
                        if (db.SaveChanges() > 0)
                        {
                            datagrdCliente.Refresh();
                            MessageBox.Show($@"Cliente {cliente.Nome} gravado com sucesso!.",@"Informação",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($@"Cliente {cliente.Nome} não pode ser gravado !.", @"Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
                cad.ShowDialog();
            }
           
        }

        private void FrmPesquisaCliente_Load(object sender, EventArgs e)
        {
            using (var db = new MotoContext())
            {
                clienteBindingSource.DataSource = db.Clientes.ToList();
            }
        }
    }
}
