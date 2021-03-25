using System;
using INFONEW_API.Models;
using System.Net.Http;



namespace TesteEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            InserirProduto();
            // AtualizarProduto();
            //ExcluirProduto();
            Console.ReadLine();
        }

        static void InserirProduto()
        {
            using (var client = new HttpClient())
            {
                Produto prd = new Produto();
                prd.NomeProd = "Impressora";
                prd.QtdEstqProd = 4;
                prd.ValUnitProd = 250;
                client.BaseAddress = new Uri("https://localhost:44366/fapen/");
                var response = client.PutAsJsonAsync("produto/", prd).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Sucesso ! " + response.ToString());
                }
                else
                    Console.Write("Erro ao inserir produto: " + response.ToString());
            }
        }

        static void AtualizarProduto()
        {
            using (var client = new HttpClient())
            {
                Produto prd = new Produto();
                prd.NomeProd = "Impressora HP";
                prd.QtdEstqProd = 5;
                prd.ValUnitProd = 250;
                client.BaseAddress = new Uri("https://localhost:44366/fapen/");
                var response = client.PutAsJsonAsync("produto/", prd).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Sucesso ao atualizar produto! " + response.ToString());
                }
                else
                    Console.Write("Erro ao atualizar produto: " + response.ToString());
            }
        }

        static void ExcluirProduto()
        {
            int idProduto = 11;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44366/fapen/");
                var response = client.DeleteAsync("produto/" + idProduto).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Sucesso ao excluir produto! " + response.ToString());
                }
                else
                    Console.Write("Erro ao excluir produto: " + response.ToString());
            }
        }
    }
}