using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using System.ComponentModel;

namespace AprendendoStructs
{
     class Program
    {
        struct Produto
        {
            public string nome;
            public float preco;
            public float peso;
            public string marca;

            public Produto(string nome, float preco, float peso, string marca)
                {   
                    this.nome = nome; //Variavel do atributo = (recebe) variavel do parametro
                    this.preco = preco;
                    this.peso = peso;
                    this.marca = marca;
                }   

            public void ExibirInfo()
            {
                Console.WriteLine($"Nome: { this.nome} ");
                Console.WriteLine($"Preço: R${this.preco}");
                Console.WriteLine($"Peso: {this.peso}");
                Console.WriteLine($"Marca: {this.marca}");
            }

            public float AdicionarCupom(float porc)
            {
                float desconto = this.preco * porc / 100f;
                return this.preco - desconto;
            }
        }

        static void Main(string[] args)
        {
           Produto bola = new Produto("Bola do ronaldinho", 100f, 1f, "nike");
           Produto Balde = new Produto("Balde vermelho", 200f, 2f, "???");

            bola.ExibirInfo(); //pegue os campos da variavel bola e exiba no console
            Console.WriteLine("----------------");
            Balde.ExibirInfo();//pegue os campos da variavel balde e exiba no console

            float valorFinal = bola.AdicionarCupom(50f);
            Balde.AdicionarCupom(50f);
        }
    }
}
