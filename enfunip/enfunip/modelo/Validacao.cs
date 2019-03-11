using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using enfunip.modelo;

namespace enfunip.modelo
{
    class Validacao
    {
        public String usuario; //teste
        public String senha;
        public String mensagem;

        public void Validar()
        {
            this.mensagem = "";
            try
            {
                if (this.usuario == "isac23" && this.senha == "123" )
                {
                    this.mensagem = "";
                }
                else
                {
                    this.mensagem = "Senha inválida";
                }
            }
            catch (Exception)
            {
                this.mensagem = "senha inválida";
                
            }
        }
    }
}