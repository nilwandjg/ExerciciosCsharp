using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCsharp
{
    class Animal
    {
        private string nome;
        private string tipo;

        //MÉTODO CONSTRUTOR:
        public Animal (string nome, string tipo)
        {
            this.setNome(nome);
            this.setTipo(tipo);
        }

        //NOME - Getter e Setter:
        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        //TIPO - Getter e Setter:
        public string getTipo()
        {
            return this.tipo;
        }
        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }
    }
}
