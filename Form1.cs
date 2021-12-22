using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //ENTRADA E SAÍDA DE ARQUIVOS

namespace Editor_de_Textos
{
    public partial class Form1 : Form
    {
        //USADO PARA FAZER LEITURA DO ARQUIVO DE TEXTO 
        StreamReader leitura = null;

        public Form1()
        {
            InitializeComponent();
        }


        //FUNÇÃO PARA NOVO DOCUMENTO
        private void Func_Novo()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }
        //BOTÃO NOVO
        private void bt_novo_Click(object sender, EventArgs e)
        {
            Func_Novo();
        }
        //MENU - NOVO
        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Func_Novo();
        }


        //FUNÇÃO PARA SAVAR DOCUMENTO 
        private void Func_Salvar()
        {
            try
            {
                //VERIFICA SE O COMPONENTE DE SALVAR RECEBEU OK
                if(this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //CASO O OK SEJA MARCADO, É GERADO O ARQUIVO PELO OBJETO DO TIPO "FILESTREAM"
                    //QUE PEDE O NOME DO ARQUIVO(SAVEFILEDIALOG1.FILENAME), O MODOLO - ABRIR/CRIAR(FILE.MODE.OPENORCREATE)
                    //E O TIPO DE ACESSO - ESCRITA/LEITURA (FILEACESS.WRITE)
                    //------CRIA O ARQUIVO 
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName,FileMode.OpenOrCreate,FileAccess.Write);
                    //TRECHO PARA GRAVAR O TEXTO ESCRITO EM ARQUIVO
                    //------CRIA A FORMA DE GRAVAR EM ARQUIVO
                    StreamWriter gravartexto = new StreamWriter(arquivo);
                    //TRECHO PARA LIMPAR O BUFFER DE GRAVAÇÃO
                    //------LIMPAR O BUFFER DE GRAVAÇÃO
                    gravartexto.Flush();
                    //TRECHO QUE DETERMINA APARTI DE QUE PONTO GRAVAR
                    //------DETERMA O PONTO DE PARTIDA DE GRAVAÇÃO
                    gravartexto.BaseStream.Seek(0,SeekOrigin.Begin);
                    //------ESCREVE OQUE ESTA EM RICHTEXTBOX1 NO GRAVADOR
                    gravartexto.Write(this.richTextBox1.Text);
                    //------LIMPAR O BUFFER DE GRAVAÇÃO
                    gravartexto.Flush();
                    //FECHA O GRAVADOR 
                    gravartexto.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error ao salvar o arquivo: " + ex.Message,"Erro ao salvar",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //BOTÃO SALVAR 
        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Func_Salvar();
        }
        //MENU - SALVAR
        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Func_Salvar();
        }
    }
}
